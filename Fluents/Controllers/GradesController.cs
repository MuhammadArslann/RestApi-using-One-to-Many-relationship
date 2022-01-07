using Fluents.Interfaces;
using Fluents.Models;
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
    public class GradesController : ControllerBase
    {
        private readonly IGrade _grade;
        public GradesController(IGrade grade)
        {
            _grade = grade;
        }
        [HttpGet]
        public IActionResult GetGrades()
        {
            return Ok(_grade.GetGrades());
        }
        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetSingleGrade(int id)
        {
            var grade = _grade.GetSingleGrade(id);
            if(grade != null)
            {
                return Ok(grade);
            }
            return NotFound("user not found!");
        }
        [HttpPost]
        public IActionResult AddGrade(Grade grade)
        {
            _grade.AddGrades(grade);
            return Ok(grade);
        }
    }
}
