using System;

namespace EDXModuleFive
{
	public class Teacher : Person
	{
		
		public Teacher (string fName, string lName, string gender, string bDay, short age)
		{
			this.Age = age;
			this.Birthday = bDay;
			this.Firstname = fName;
			this.Gender = gender;
			this.LastName = lName;
		}
			
		public void GradeTest(){
			Console.WriteLine ("Teacher {0} {1} is grading a test", this.Firstname, this.LastName);
		}

	
	}
}

