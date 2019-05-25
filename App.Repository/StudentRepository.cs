using App.Gateway;
using App.Models;
using System.Collections.Generic;
using System.Linq;

namespace App.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> GetAll()
        {
            var students = _dbContext.Students.ToList();

            return students;
        }
    }
}
