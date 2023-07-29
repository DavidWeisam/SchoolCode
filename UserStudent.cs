using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class UserStudent
	{
		static void Main(string[] args)
		{
			Student[] arr = new Student[5];	

			string name;
			int grd1;
			int grd2;
			int grd3;
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("Enter your name:");
				name = Console.ReadLine();

				Console.WriteLine("Enter the first grade: ");
				grd1 = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter the second grade: ");
				grd2 = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter the third grade: ");
				grd3 = int.Parse(Console.ReadLine());

				arr[i] = new Student(name, grd1, grd2, grd3);
			}

			ShowArr(arr);

			Console.WriteLine("Enter your name:");
			name = Console.ReadLine();

			while (name != "XXX")
			{
				
				Console.WriteLine("Enter the new second grade: ");
				grd2 = int.Parse(Console.ReadLine());

				for (int j = 0; j < arr.Length; j++)
				{
					if (name == arr[j].GetName())
					{
						if(grd2 > arr[j].GetGrd2())
							arr[j].SetGrd2(grd2);
					}
				}

				Console.WriteLine("Enter your name:");
				name = Console.ReadLine();
			}

			ShowArr(arr);
		}

		public static void ShowArr(Student[] arr)
		{
			Console.WriteLine();
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i].ToString());
				Console.WriteLine();
			}
		}
	}
}
