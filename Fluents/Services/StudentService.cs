using Fluents.Db;
using Fluents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents.Classes
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _schoolContext;
        public StudentService(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }


        public Student AddStudent(Student student)
        {
            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();
            return student;
        }

        public Student GetSingleStudent(int id)
        {
            var singleStd = _schoolContext.Students.FirstOrDefault(x => x.Id == id);
            return singleStd;
        }

        public List<Student> GetStudent()
        {
            return _schoolContext.Students.ToList();
        }
    }
}
