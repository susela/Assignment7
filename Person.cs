using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_inheritance.Model
{
    public class Person
    {
        //fields
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        //Read_data() method
        public virtual void Read_data()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
        }

        //Display method
        public virtual void Display_data()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}