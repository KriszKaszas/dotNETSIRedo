using System;

namespace CreateClass
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        Room room;
        public Employee(string name, DateTime birthDate, string inputGender,
            int inputSalary, string inputProfession, int roomNumber) : base(name, birthDate, inputGender)
        {
            Salary = inputSalary;
            Profession = inputProfession;
            room = new Room(roomNumber);
        }

        public override string ToString()
        {
            return "Person: " + Name + "\n" + "Birth date: " + BirthDate + "\n" + "Gender: "
                + gender + "\n" + "Profession: " + Profession + "\n" + "Salary: " 
                + Salary + "\n" + "Room Number: " + room.RoomNumber;
        }
    }
}
