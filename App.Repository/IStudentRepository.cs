using App.Models;
using System.Collections.Generic;

namespace App.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
    }
}
