using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudent();

        Student AddStudent(Student student);

        Student GetSingleStudent(int id);
    }
}
