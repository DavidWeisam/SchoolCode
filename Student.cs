using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class Student
	{
		private string name;
		private int grd1;
		private int grd2;
		private int grd3;
		

		public Student(string name, int grd1, int grd2, int grd3)
		{
			this.name = name;
			this.grd1 = grd1;
			this.grd2 = grd2;
			this.grd3 = grd3;
		}

		public Student(string name)
		{
			this.name = name;
			this.grd1 = 0;
			this.grd2 = 0;
			this.grd3 = 0;
		}

		public string GetName()
		{
			return this.name;
		}

		public int GetGrd1()
		{
			return grd1;
		}

		public int GetGrd2()
		{
			return grd2;
		}

		public int GetGrd3()
		{
			return grd3;
		}

		public void SetName(string name)
		{
			this.name = name;
		}

		public void SetGrd1(int grd1)
		{
			this.grd1 = grd1;
		}

		public void SetGrd2(int grd2)
		{
			this.grd2 = grd2;
		}

		public void SetGrd3(int grd3)
		{
			this.grd3 = grd3;
		}

		public double GetEvg()
		{
			return((this.grd1 + this.grd2 + this.grd3) / 3.0);
		}

		public override string ToString()
		{
			return ($"Name: {name}, first grade: {grd1}, second grade: {grd2}, third: {grd3}, average: {GetEvg()}");
		}



	}
}
