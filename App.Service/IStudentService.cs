using App.Models;
using System.Collections.Generic;

namespace App.Service
{
    public interface IStudentService
    {
        List<Student> GetAll();
    }
}
