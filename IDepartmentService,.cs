using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDepartmentService
    {
        public string[] listOfCourses{ get; set; }

        public string instructorHeadOfDepartment { get; set; }

        public double yearlyBudget { get; set; }

        DateTime schoolYearStartstartDate { get; set; }

        DateTime schoolYearEndDate { get; set; }

    }
}
