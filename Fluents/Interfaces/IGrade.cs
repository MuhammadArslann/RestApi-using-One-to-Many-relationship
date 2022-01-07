using Fluents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents.Interfaces
{
    public interface IGrade
    {
        List<Grade> GetGrades();

        Grade AddGrades(Grade grade);

        Grade GetSingleGrade(int id);
    }
}
