using ConsoleEmployeeAppv2025.Model;

namespace ConsoleEmployeeAppv2025
{
    internal class EmployeeApp
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a general employee
                Employee emp = new Employee(1, "Sruthi", "Software developer", 45000);
                emp.DisplayDetails();

                Console.WriteLine();

                // Create an executive
                Executive exec = new Executive(2, "Ram", "Data Analyst", 76000);
                exec.DisplayDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
