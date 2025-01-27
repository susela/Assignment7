using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent_Appv2025.Model
{
    public class Professor
    {

        // fields
        public string ProfName { get; set; }
        public string EmpID { get; set; }
        public string ProfMajor { get; set; }

        //default Constructor
        public Professor()
        {

        }

        // Parameterized Constructor
        public Professor(string name, string empId, string major)
        {
            ProfName = name;
            EmpID = empId;
            ProfMajor = major;
        }

        // Teach() Method
        public void Teach()
        {
            Console.WriteLine($"Professor {ProfName} is teaching {ProfMajor}.");
        }
    }
}
