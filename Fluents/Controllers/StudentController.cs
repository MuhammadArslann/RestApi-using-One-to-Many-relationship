using Fluents.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studnetService;
        private readonly IGrade _grade;
        public StudentController(IStudentService studentService, IGrade grade)
        {
            _studnetService = studentService;
            _grade = grade;
        }
        //[HttpGet]
        //public IActionResult GetAllStudent()
        //{
        //    return Ok(_studnetService.GetStudent());
        //}
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetSingleStudent(int id)
        {
            var std = _studnetService.GetSingleStudent(id);
            if (std != null)
            {
                return Ok(std);
            }
            return NotFound("Student not found!");
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studnetService.AddStudent(student);
            return Ok(student);
        }
        [HttpGet]
        public IActionResult GetStudentWithGrades()
        {
            if (ModelState.IsValid)
            {
                var result = from s in _studnetService.GetStudent()
                             join g in _grade.GetGrades()
                             on s.GradeId equals g.GradeId into eGroup
                             from g in eGroup.DefaultIfEmpty()
                             select new
                             {
                                 StudentId = s.Id,
                                 StudentName = s.Name,
                                 GradeId = g.GradeId,
                                 GradeName = g.GradeName,
                                 GradeSection = g.Section
                             };
                foreach(var v in result)
                {
                return Ok(v);
                }
            }
            return NotFound("Table cant created!");
        }

    }
}
