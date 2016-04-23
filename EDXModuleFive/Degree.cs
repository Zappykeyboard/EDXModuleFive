using System;

namespace EDXModuleFive
{
	public class Degree
	{
		private string degreeValue;
		public Course course;

		public Course Course{ get{return course;} set{course = value;}}
		public string DegreeValue{get{return degreeValue;} set{degreeValue = value;}}

		public Degree (string dValue)
		{
			this.DegreeValue = dValue;
		}
	}
}

