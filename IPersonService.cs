using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IPersonService
    {
        public string name { get; set; }
        public string address { get; set; }
        public string birthday { get; set; }
        public string salary { get; set; }
        public void InsertAddress(string address);
        public void UpdateAddress(int i, string address);

        public int CalculateAge();

        public string GetBirthday();

        public int CalculateSalary();

        public int GetAddresses();
    }
}
