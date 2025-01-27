using ConsoleStudent_Appv2025.Model;

namespace ConsoleStudent_Appv2025
{
    internal class StudApp
    {
        static void Main(string[] args)
        {

            // Creating a Student instance
            Console.Write("Enter the student name:");
            String Name = Console.ReadLine();
            Console.Write("Enter the student id:");
            string StudentID = Console.ReadLine();
            Console.Write("Enter the student  major:");
            string Major = Console.ReadLine();
            Console.Write("Enter the student level(Graduate or post graduate):");
            string Level = Console.ReadLine();

            Student student = new Student(Name, StudentID, Major, Level);
            student.Study();

            // Creating a Professor instance
            Console.Write("Enter the professor name:");
            String ProfName = Console.ReadLine();
            Console.Write("Enter the professor id:");
            string empID = Console.ReadLine();
            Console.Write("Enter the professor's major:");
            string ProfMajor = Console.ReadLine();


            Professor professor = new Professor(ProfName, empID, ProfMajor);
            professor.Teach();

            // Creating a Course instance
            Console.Write("Enter the course title:");
            String Title = Console.ReadLine();
            Console.Write("Enter the duration:");
            int Duration = int.Parse(Console.ReadLine());

            Course course = new Course(Title, Duration);
            course.DisplayDetails();


            //keep the console window open
            Console.WriteLine("Press any key to continue...!");
            Console.ReadKey();
        }
    }
}