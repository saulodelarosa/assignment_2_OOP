using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IStudentService : IPersonService
    {
        public string[] courses { get; set; }

        public string[,] grades { get; set; }

        public double GPA { get; set; }

        public int CalculateGPA();

    }
}
