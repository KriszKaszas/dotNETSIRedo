using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room room { get; set; }
        public Employee(string name, DateTime birthDate, string inputGender,
            int inputSalary, string inputProfession) : base(name, birthDate, inputGender)
        {
            Salary = inputSalary;
            Profession = inputProfession;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.room = new Room(room.Number);
            return newEmployee;
        }

        public override string ToString()
        {
            return "Person: " + Name + "\n" + "Birth date: " + BirthDate + "\n" + "Gender: "
                + gender + "\n" + "Profession: " + Profession + "\n" + "Salary: " 
                + Salary + "\n" + "Room Number: " + room.Number + "\n";
        }
    }
}
