using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class KalmarUse
	{
		static void Main(string[] args)
		{
			Kalmar k1 = new Kalmar("red", 3, 4);
			
			Console.WriteLine("Type the number of the pens: ");
			int x = int.Parse(Console.ReadLine());

			Console.WriteLine("Type the number of pencils: ");
			int y = int.Parse(Console.ReadLine());

			Kalmar k2 = new Kalmar("blue", x, y);

			x = 0;
			y = 0;

			int p1 = k1.GetPencile();
			int p2 = k2.GetPencile();

			if (p1 > p2)
			{
				k1.RemovePencile();
				k2.Addpencile();
			}
			else if (p1 < p2)
			{
				k2.RemovePencile();
				k1.Addpencile();
			}

			Console.WriteLine("Type number of pens: ");
			x = int.Parse(Console.ReadLine());

			int half = x / 2;

			for(int i = 0; i < half; i++)
			{
				k1.AddPen();
				k2.AddPen();
			}

			if (x / 2 != 0)
			{
				if (k1.GetPen() < k2.GetPen())
					k1.AddPen();

				else
					k2.AddPen();
			}


			Console.WriteLine(k1.ToString());
			Console.WriteLine(k2.ToString());
		}
	}
}
