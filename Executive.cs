using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmployeeAppv2025.Model
{
    public class Executive : Employee
    {
        public Executive(int employeeNo, string name, string designation, decimal basicPay)
            : base(employeeNo, name, designation, basicPay)
        {
            if (basicPay <= 10000)
            {
                throw new ArgumentException("Basic Pay for an Executive must be more than Rs. 10,000.");
            }
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Executive Details:");
            base.DisplayDetails();
        }
    }
}