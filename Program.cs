using System.Runtime.InteropServices;

namespace Making_a_Name_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name student;
            Name beatle = new Name("Sir", "Paul", "McCartney");
            Console.WriteLine(beatle.FirstName);
            Console.WriteLine(beatle.LastName);
            Console.WriteLine(beatle);  // The ToString() method is automatically called Here
            Console.WriteLine(beatle.Initials);
            beatle.FirstName = "James";
            Console.WriteLine(beatle);
            Console.WriteLine(beatle.Initials);
            student = new Name("Jane", "Doe");
            Console.WriteLine($"{student}, your username is: {student.UserName}");
           
        }
    }
}