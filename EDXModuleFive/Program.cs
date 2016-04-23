using System;

namespace EDXModuleFive
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var student1 = new Student ("John","Doe","male","14/12/1990",25);
			var student2 = new Student ("Carol","Smith","female","10/10/1990",25);
			var student3 = new Student ("Mack","White","male","05/04/1990",25);
			//var teacher = new Teacher ("Benedict","Cumberbacht", "male", "01/02/1985",30);





			//could not find a more efficient way to add grades to the stack. Suggestions appreciated.
			student1.Grades.Push (18);
			student1.Grades.Push (25);
			student1.Grades.Push (27);
			student1.Grades.Push (30);
			student1.Grades.Push (20);

			student2.Grades.Push (20);
			student2.Grades.Push (21);
			student2.Grades.Push (25);
			student2.Grades.Push (30);
			student2.Grades.Push (18);

			student3.Grades.Push (17);
			student3.Grades.Push (23);
			student3.Grades.Push (14);
			student3.Grades.Push (21);
			student3.Grades.Push (30);

			var ProgrammingWithCSharp = new Course("Programming with C#");
			ProgrammingWithCSharp.Students.Add (student1);
			ProgrammingWithCSharp.Students.Add (student2);
			ProgrammingWithCSharp.Students.Add (student3);
			ProgrammingWithCSharp.ListStudents();

			Console.ReadLine ();
//			var bachelor = new Degree ("Bachelor of Science");
//
//			bachelor.Course = ProgrammingWithCSharp;
//
//			var informationTechnology = new UProgram ("Information Technology");
//
//			informationTechnology.Degree = bachelor;
//
//			Console.WriteLine ("The {0} program contains the {1} degree",informationTechnology.ProgramName,
//				bachelor.DegreeValue);
//
//			Console.WriteLine ("\nThe {0} degree contains the course {1}", bachelor.DegreeValue,
//				ProgrammingWithCSharp.CourseName);
//
//			Console.WriteLine ("\nThe {0} course contains {1} student(s)", ProgrammingWithCSharp.CourseName,
//				student1.NumOfStudents);
//
//			Console.WriteLine ("\nStudents {0}, {1}, {2} are attending the {3} course with teacher {4}",
//				student1.GetNames(), student2.GetNames(), student3.GetNames(),  ProgrammingWithCSharp.CourseName,teacher.GetNames());
//


		}

	
	}
}
