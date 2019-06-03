using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime personBirthDate = new DateTime(1999, 05, 28);
            DateTime employeeBirthDate = new DateTime(1992, 09, 25);
            Person Anna = new Person("Anna", personBirthDate, "Female");
            Employee Krisz = new Employee("Krisz", employeeBirthDate, "Male", 10000000, "Software Dev", 1);
            Console.WriteLine(Anna.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(Krisz.ToString());
            Console.ReadLine();
        }
    }
}
