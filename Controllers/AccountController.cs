﻿using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using E_learning_Platform.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_learning_Platform.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole<int>> _roleManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly IEnrollmentRepository _enrollmentRepository;

        public AccountController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IEnrollmentRepository enrollmentRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _enrollmentRepository = enrollmentRepository;
        }

        public IActionResult Register(string? returnUrl)
		{
            ViewBag.ReturnUrl = returnUrl ?? "/";
            UserRegisterViewModel userRegisterViewModel = new UserRegisterViewModel
			{
				Roles = _roleManager.Roles
					.Select(x => new SelectListItem { 
						Text = x.Name, Value = x.Id.ToString()
					}),
			};
			return View(userRegisterViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(UserRegisterViewModel userRegister, 
			string selectedRoleId, string? returnUrl)
		{
			if (!ModelState.IsValid)
			{
                UserRegisterViewModel userRegisterViewModel = new UserRegisterViewModel
                {
                    Roles = _roleManager.Roles
                    .Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }),
                };
                return View(userRegisterViewModel);
                
			}
            ApplicationUser user = new ApplicationUser
            {
                FirstName = userRegister.FirstName,
                LastName = userRegister.LastName,
                Email = userRegister.Email,
                UserName = $"{userRegister.FirstName}-{userRegister.LastName}{Guid.NewGuid().ToString().Substring(0, 4)}"
            };
            var result = await _userManager.CreateAsync(user, userRegister.Password);
            if (result.Succeeded)
            {
                var role = await _roleManager.FindByIdAsync(selectedRoleId);
                await _userManager.AddToRoleAsync(user, role?.Name ?? "test");
            }
            await _signInManager.PasswordSignInAsync(user, userRegister.Password, false, false);

            return Redirect(returnUrl ?? "/");

        }

		public IActionResult Login(string? returnUrl)
		{
			ViewBag.ReturnUrl = returnUrl ?? "/";
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(UserLoginViewModel userLogin, string? returnUrl)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(userLogin.Email);
				if(user is not null)
				{
					await _signInManager.SignOutAsync();
					var result = await _signInManager.PasswordSignInAsync(user, userLogin.Password, false, false);
					if (result.Succeeded)
					{
						return Redirect(returnUrl ?? "/");
					}
				}
				ModelState.AddModelError("", "Invaild Email or Password");
			}
			return View(userLogin);
		}

		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

		public async Task<IActionResult> Profile(string username)
		{
			var user = await _userManager.FindByNameAsync(username);
			return View(user);
		}
		[HttpPost]
        public async Task<IActionResult> Profile(ApplicationUser userModel)
        {
			var user = await _userManager.FindByEmailAsync(userModel.Email);
			user.FirstName = userModel.FirstName;
			user.LastName = userModel.LastName;
			user.PhoneNumber = userModel.PhoneNumber;
			await _userManager.UpdateAsync(user);
            return View(user);
        }

		public async Task<IActionResult> ListUserEnrolledCourses(string userId)
		{
            if (userId is null)
                return View("MyCourses");

            var id = int.Parse(userId);
			if (id == 0)
				return View("MyCourses");

			var courses = await _enrollmentRepository.GetAllAsync(id);
			return View("MyCourses", courses);
		}
		 
    }
}
