using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        Gender gender;

        public Person(string name, DateTime birthDate, String inputGender)
        {
            Name = name;
            BirthDate = birthDate;
            if (inputGender == "Male")
            {
                gender = Gender.MALE;
            }
            else
            {
                gender = Gender.FEMALE;
            }
        }

        public override string ToString()
        {
            return "Person: " + Name + "\n" + "Birth date: " + BirthDate + "\n" + "Gender: " + gender;
        }

    }
}
