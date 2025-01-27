using Assignment1_inheritance.Model;

namespace Assignment1_inheritance
{
    internal class StudempApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Enter Student Data");
                Console.WriteLine("2. Enter Employee Data");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var student = new Student();
                        student.Read_data();
                        student.Compute_grade();
                        student.Display_data();
                        break;

                    case 2:
                        var employee = new Employee();
                        employee.Read_data();
                        employee.Compute_Salary();
                        employee.Display_data();
                        break;

                    case 3:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }



            //keep the console window open
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}