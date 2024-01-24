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
        Student s1 = new Student("Jack", 1001);
        Student s2 = new Student("Jill", 1024);
        Student s3 = new Student("Hansel", 87);
        Student s4 = new Student("Gretl", 45);

        //Populate the list with your instances.
        students.Add(s1);
        students.Add(s2);
        students.Add(s3);
        students.Add(s4);


        //GOING ROGUE: report cards are in!!
        s1.MathGrade = 73.89;
        s2.MathGrade = 96.7;
        s3.MathGrade = 82.53;
        s4.MathGrade = 92.86;

        s1.ScienceGrade = 78.2;
        s2.ScienceGrade = 93.56;
        s3.ScienceGrade = 87.35;
        s4.ScienceGrade = 95.47;

        s1.EnglishGrade = 93.42;
        s2.EnglishGrade = 81.28;
        s3.EnglishGrade = 86.92;
        s4.EnglishGrade = 94.5;

        s1.HistoryGrade = 91.33;
        s2.HistoryGrade = 77.82;
        s3.HistoryGrade = 84.9;
        s4.HistoryGrade = 96.52;

        s1.OtherGrades = new double[] { 82.5, 73.4, 89.6 };
        s2.OtherGrades = new double[] { 87.6, 79.2 };
        s3.OtherGrades = new double[] { 88.375 };
        s4.OtherGrades = new double[] { 90.482, 94, 73, 99.524, 96.39, 90.227 };


        //Call the AddGrade() method twice for each student.
        //Be sure to invoke the overloads.

        s1.AddGrade(s1.MathGrade);
        s1.AddGrade(s1.ScienceGrade);
        s1.AddGrade(s1.EnglishGrade);
        s1.AddGrade(s1.HistoryGrade);
        s1.AddGrade(s1.OtherGrades);

        s2.AddGrade(s2.MathGrade, s2.EnglishGrade, s2.ScienceGrade, s2.HistoryGrade);
        s2.AddGrade(s2.OtherGrades);

        s3.AddGrade(s3.EnglishGrade);
        s3.AddGrade(s3.MathGrade, s3.ScienceGrade, s3.HistoryGrade);
        s3.AddGrade(s3.OtherGrades);

        s4.AddGrade(s4.MathGrade, s4.EnglishGrade, s4.ScienceGrade, s4.HistoryGrade);
        s4.AddGrade(s4.OtherGrades);

        //Loop through your list of students and display their info.

        foreach (Student s in students)
        {
            Console.WriteLine($"STUDENT #{s.ID}: {s.Name}");
            Console.WriteLine();

            Console.WriteLine($"{s.Name}'s grades are as follows:");
            Console.WriteLine();
            Console.WriteLine($"Math: {s.MathGrade}");
            Console.WriteLine($"Science: {s.ScienceGrade}");
            Console.WriteLine($"English: {s.EnglishGrade}");
            Console.WriteLine($"History: {s.HistoryGrade}");

            Console.Write("Other classes: ");
            for (int i = 0; i < s.OtherGrades.Length-1; i++)
            {
                Console.Write(s.OtherGrades[i] + ", ");
            }
            Console.WriteLine(s.OtherGrades[s.OtherGrades.Length - 1]);

            Console.WriteLine();
            Console.WriteLine($"AVERAGE GRADE: {s.CalculateAverageGrade()}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("-----------------------------------");

        //BONUS: Enroll students in courses
        Course c1 = new Course() { CourseName = "Home Economics", CourseCode = "41678J"};
        Course c2 = new Course() { CourseName = "Photography", CourseCode = "437289L"};
        Course c3 = new Course() { CourseName = "Social Studies", CourseCode = "643127897T"};
        Course c4 = new Course() { CourseName = "Spanish", CourseCode = "3562189S"};
        Course c5 = new Course() { CourseName = "French", CourseCode = "4362789F"};
        Course c6 = new Course() { CourseName = "Show Choir", CourseCode = "43621789E"};

        c1.Register(s1);
        c1.Register(s3);
        c1.Register(s4);

        c2.Register(s4);
        c2.Register(s2);

        c3.Register(s4);
        c3.Register(s4);

        c4.Register(s1);
        c4.Register(s2);
        c4.Register(s4);

        c5.Register(s4);

        c6.Register(s4);
        c6.Register(s1);

        List<Course> courseList = new List<Course>() { c1, c2, c3, c4, c5, c6 };

        foreach (Course c in courseList)
        {
            Console.WriteLine($"Students enrolled in {c.CourseName} (Course ID #{c.CourseCode}):");
            int numberOfStudents = 0;
            foreach (Student s in c.EnrolledStudents)
            {
                Console.WriteLine($"- {s.Name} (#{s.ID})");
                numberOfStudents++;
            }
            Console.WriteLine($"Total enrollment: {numberOfStudents}");
            Console.WriteLine();
        }
    }
}

