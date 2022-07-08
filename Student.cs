using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : IStudentService
    {
        public string[] courses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[,] grades { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double GPA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string birthday { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CalculateAge()
        {
            throw new NotImplementedException();
        }

        public int CalculateGPA()
        {
            throw new NotImplementedException();
        }

        public int CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public int GetAddresses()
        {
            throw new NotImplementedException();
        }

        public string GetBirthday()
        {
            throw new NotImplementedException();
        }

        public void InsertAddress(string address)
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(int i, string address)
        {
            throw new NotImplementedException();
        }
    }
}
