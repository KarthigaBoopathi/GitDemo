using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
	public enum CourseName
	{
		AIML,Dotnet,Java
	}
    public class Student
    {
		private int _rollno;

		public int Rollnumber
		{
			get { return _rollno; }
			set { _rollno = value; }
		}

		private int _name;

		public int Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public CourseName coursename { get; set; }
    }
}
