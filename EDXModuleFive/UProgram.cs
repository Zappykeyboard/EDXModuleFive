using System;

namespace EDXModuleFive
{
	public class UProgram
	{
		private Degree degree;
		private string programName;

		public string ProgramName{get{return programName;} set{programName = value;}}
		public Degree Degree{get{return degree;}set{degree = value;}}

	
		public UProgram (string pName)
		{
			this.ProgramName = pName;
		}
	}
}

