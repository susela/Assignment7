using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent_Appv2025.Model
{
    public class Course
    {
        // Fields
        public string Title { get; set; }
        public int Duration { get; set; } // Duration in weeks or hours

        //Default Constructor
        public Course()
        {

        }

        // Paramterized Constructor
        public Course(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        //DisplayDetails() Method
        public void DisplayDetails()
        {
            Console.WriteLine($"Course Title: {Title}, Duration: {Duration} weeks.");
        }
    }
}

