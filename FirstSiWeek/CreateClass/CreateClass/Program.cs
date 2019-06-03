using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime BirthDate = new DateTime(1999, 05, 28);
            Person Anna = new Person("Anna", BirthDate, "Female");
            Console.WriteLine(Anna.ToString());
            Console.ReadLine();
        }
    }
}
