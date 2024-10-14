﻿using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Data.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddEnrollmentsAsync(int userId, IEnumerable<Course> courses)
        {
            foreach (var course in courses)
            {
                var enrollment = new Enrollement
                {
                    UserId = userId,
                    CourseId = course.Id,
                    Progress = new Random().Next(0, 100)

                };
                await _context.Enrollement.AddAsync(enrollment);
                _context.UserCoursesCart.Remove(new UserCoursesCart { CourseId = course.Id, UserId = userId });
                var effectedRows = await _context.SaveChangesAsync();
                if (effectedRows == 0)
                {
                    return false;
                }
                
            }
            return true;

        }

        public async Task<IEnumerable<Enrollement>> GetAllAsync(int userId)
        {
            return await _context.Enrollement
                .Where(e => e.UserId == userId)
                .Include(e => e.Course)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
