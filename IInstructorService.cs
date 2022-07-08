using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IInstructorService : IPersonService
    {
        public string department { get; set; }

        public bool isHeadofDepartment { get; set; }

        public DateTime joinDate { get; set; }

        public int bonusSalary { get; set; }

        public int Experiance();
        public int CalculatebonusSalary();

    }
}
