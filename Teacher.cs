using System;
namespace baru.LatihanInheritance
{
    public class Teacher : Person
    {
        public Teacher(string name,int age):base(name,age)
        {
           
        }

    public string TeacherId { get; set; }
    public string Subject { get; set; }
}
}