using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent_Appv2025.Model
{
    public class Student
    {
        //fields
        public string Name { get; set; }
        public string StudentID { get; set; }
        public string Major { get; set; }
        public string Level { get; set; } // "Graduate" or "Post Graduate"

        //default Constructor
        public Student()
        {

        }

        // Parameterized Constructor
        public Student(string name, string studentId, string major, string level)
        {
            Name = name;
            StudentID = studentId;
            Major = major;
            Level = level;
        }

        // Study() Method
        public void Study()
        {
            Console.WriteLine($"{Name} is studying {Major} as a {Level} student.");
        }
    }
}