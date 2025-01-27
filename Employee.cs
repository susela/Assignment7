using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmployeeAppv2025.Model
{
    public class Employee
    {
        public int EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        private decimal basicPay;

        public decimal BasicPay
        {
            get { return basicPay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Basic Pay cannot be negative.");
                }
                basicPay = value;
            }
        }

        public Employee(int employeeNo, string name, string designation, decimal basicPay)
        {
            EmployeeNo = employeeNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee No: {EmployeeNo}\nName: {Name}\nDesignation: {Designation}\nBasic Pay: {BasicPay:C}");
        }
    }
}

