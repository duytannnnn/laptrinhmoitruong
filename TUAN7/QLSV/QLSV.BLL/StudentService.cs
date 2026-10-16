using System;
using System.Collections.Generic;
using System.Text;

using QLSV.DAL;

namespace QLSV.BLL
{
    public class StudentService
    {
        private readonly StudentRepository _repo = new StudentRepository();

        public Task<List<Student>> GetAllAsync() => _repo.GetAllAsync();

        public Task<List<Student>> GetPassedAsync() => _repo.GetPassedAsync();

        public async Task AddAsync(string fullName, double grade)
        {
            Validate(fullName, grade);
            await _repo.AddAsync(new Student { FullName = fullName.Trim(), Grade = grade });
        }

        public async Task UpdateAsync(int id, string fullName, double grade)
        {
            Validate(fullName, grade);
            await _repo.UpdateAsync(id, fullName.Trim(), grade);
        }

        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);

        private static void Validate(string fullName, double grade)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Vui lòng nhập họ tên.");
            if (grade < 0 || grade > 10)
                throw new ArgumentException("Điểm phải từ 0 đến 10.");
        }
    }
}
