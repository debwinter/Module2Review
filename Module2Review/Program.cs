using System.Diagnostics;

namespace Module2Review;
class Program
{
    static void Main(string[] args)
    {
        // Create a C# console application that manages student grades.

        //TODO
        //In the main method, create a List of type Student.
        List<Student> students = new List<Student>();

        //Create 4 instances of type Student.
        Student student1 = new Student("Jack", 1001);
        Student student2 = new Student("Jill", 1024);
        Student student3 = new Student("Hansel", 87);
        Student student4 = new Student("Gretl", 45);

        //Populate the list with your instances.
        foreach (Student s in Student)
        {
            students.Add(s);
        }
    }
}

