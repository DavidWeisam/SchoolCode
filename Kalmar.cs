using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class Kalmar
	{

		private string color;
		private int pen;
		private int pencile;

		public Kalmar(string color, int pen, int pencile) { 
			this.color = color;
			this.pen = pen;
			this.pencile = pencile;
		}

		public string GetColor()
		{
			return this.color;		
		}

		public int GetPen()
		{
			return this.pen;
		}
		public int GetPencile() 
		{ 
			return this.pencile;
		}

		public void AddPen()
		{
			this.pen += 1;
		}

		public void Addpencile()
		{
			this.pencile += 1;
		}

		public void RemovePen()
		{ 
			this.pen -= 1;
		}

		public void RemovePencile()
		{
			this.pencile -= 1;
		}

		public override string ToString()
		{
			return ($"The color of the kalmar is {color}, The number of pens in the clarmar is {pen} and  the number of the pencils is {pencile}");
		}



	}
}
