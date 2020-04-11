using System;
namespace baru.LatihanInheritance
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {

        }

    public string StudentId { get; set; }
    public string Email { get; set; }
    }
}