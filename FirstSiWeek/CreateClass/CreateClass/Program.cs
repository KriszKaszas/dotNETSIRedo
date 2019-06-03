using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, "Male", 1000, "léhűtő");
            Kovacs.room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
