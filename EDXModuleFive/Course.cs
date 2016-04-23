using System;
using System.Collections;

namespace EDXModuleFive
{
	public class Course
	{
		private string courseName;
		public ArrayList Students = new ArrayList();

		public string CourseName{ get{return courseName;} set{courseName=value;}}

		public Course (string cName)
		{
			this.CourseName = cName;
		}

		public void ListStudents(){
			foreach (Object obj in Students)
			{
				Student s = (Student)obj;

				Console.WriteLine (s.Firstname +" " + s.LastName);
			}
		}
	}
}

