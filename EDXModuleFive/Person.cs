using System;

namespace EDXModuleFive
{
	public class Person
	{
		private string birthday;
		private string gender;
		private short age;
		private string _firstName;
		private string _lastName;

		public string Birthday{get{return birthday;}set{birthday = value;}}
		public string Gender{get{return gender;}set{gender = value;}}
		public short Age {get{return age;}set{age = value;}}
		public string Firstname { get { return _firstName; } set {_firstName = value;}}
		public string LastName{ get{return _lastName;}  set{_lastName = value;}}
		public Person ()
		{
		}
		public string GetNames(){
			return LastName + " " + Firstname;
		}
	}
}

