using System;
using System.Collections;
using System.Collections.Generic;

namespace Module2Review
{
//Create a class called Student

    public class Student
	{
		public Student()
		{
		}

        //Create a property called Name of type string
        public string Name { get; set; }

        //Create a property called ID of type int
        public int ID { get; set; }

        //Create a property called Grades of type List
        public List<double> Grades = new List<double>();

        //Create a method called AddGrade in the Student class
        public void AddGrade(double grade)
		{
			Grades.Add(grade);
		}

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            return (Grades.Count == 0) ? 0 : Grades.Average();
        }

	}
}

