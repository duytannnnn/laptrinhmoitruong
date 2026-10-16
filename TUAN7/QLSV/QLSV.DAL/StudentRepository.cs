using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace QLSV.DAL
{
    public class StudentRepository
    {
        public async Task<List<Student>> GetAllAsync()
        {
            using var context = new AppDbContext();
            return await context.Students.ToListAsync();
        }

        public async Task<List<Student>> GetPassedAsync()
        {
            using var context = new AppDbContext();
            return await context.Students
                .Where(sv => sv.Grade >= 5)
                .OrderByDescending(sv => sv.Grade)
                .ToListAsync();
        }

        public async Task AddAsync(Student sv)
        {
            using var context = new AppDbContext();
            context.Students.Add(sv);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, string fullName, double grade)
        {
            using var context = new AppDbContext();
            var sv = await context.Students.FindAsync(id);
            if (sv != null)
            {
                sv.FullName = fullName;
                sv.Grade = grade;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using var context = new AppDbContext();
            var sv = await context.Students.FindAsync(id);
            if (sv != null)
            {
                context.Students.Remove(sv);
                await context.SaveChangesAsync();
            }
        }
    }
}