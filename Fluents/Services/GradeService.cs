using Fluents.Db;
using Fluents.Interfaces;
using Fluents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents.Classes
{
    public class GradeService : IGrade
    {
        private readonly SchoolContext _schoolContext;
        public GradeService(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public Grade AddGrades(Grade grade)
        {
            _schoolContext.Grades.Add(grade);
            _schoolContext.SaveChanges();
            return grade;
        }

        public List<Grade> GetGrades()
        {
            return _schoolContext.Grades.ToList();
        }

        public Grade GetSingleGrade(int id)
        {
            var singleGrade = _schoolContext.Grades.FirstOrDefault(x => x.GradeId == id);
            return singleGrade;
        }
    }
}
