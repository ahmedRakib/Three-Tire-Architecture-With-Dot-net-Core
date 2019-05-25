using App.Models;
using App.Repository;
using System.Collections.Generic;

namespace App.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
    }
}
