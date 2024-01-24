using System;
using System.Collections.Generic;

namespace Module2Review
{
	public class Course
	{
		public Course()
		{
			EnrolledStudents = new List<Student>();
		}

		public string CourseName { get; set; }

		public string CourseCode { get; set; }

		public List<Student> EnrolledStudents;

		public void Register(Student s)
		{
			if (!EnrolledStudents.Contains(s))
			{
				EnrolledStudents.Add(s);
			}
		}
	}
}

