static void Main(string[] args)
{
    Person person = new Person("Mike",20);
    person.GetNameAndAge();

    Teacher teacher = new Teacher("Thomas",35);
    teacher.TeacherId = "190302";
    teacher.Subject = "Math";
    teacher.GetNameAndAge();

    Student student = new Student("Sara",19);
    student.StudentId = "10506";
    student.Email = "sara1234@amikom.ac.id";
    student.GetNameAndAge();

    Console.Readkey();
}