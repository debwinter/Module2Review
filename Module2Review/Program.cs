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

    }
}

