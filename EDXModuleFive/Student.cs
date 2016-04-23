using System;
using System.Collections;

namespace EDXModuleFive
{
	public class Student : Person
	{
		
		private static int _numOfStudents;

		public Stack Grades = new Stack ();

		public int NumOfStudents {get{return _numOfStudents;}set{_numOfStudents = value;}}


		public Student (string fName, string lName, string gender, string bDay, short age)
		{
			this.Age = age;
			this.Birthday = bDay;
			this.Firstname = fName;
			this.Gender = gender;
			this.LastName = lName;
			this.NumOfStudents += 1;
			
		}

		public void TakeTest(){
			Console.WriteLine ("Student {0} {1} took the test", this.Firstname, this.LastName);
		}

	
	}
}

