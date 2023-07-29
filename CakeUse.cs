using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewOne
{
	internal class CakeUse
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the type of the first cake: ");
			string type = Console.ReadLine();

			Console.WriteLine("enter the number of slices of the first cake: ");
			int numOf = int.Parse(Console.ReadLine());

			while (numOf < 0) 
			{
				Console.WriteLine("enter the number of slices of the first cake: ");
				numOf = int.Parse(Console.ReadLine());
			}


			Console.WriteLine("Enter othe taste rating rating(0 - 10): ");
			int rating = int.Parse(Console.ReadLine());	

			Cake cake1 = new Cake(type, numOf, rating);

			Console.WriteLine("Enter the type of the second cake: ");
			type = Console.ReadLine();

			Console.WriteLine("enter the number of slices of the second cake: ");
			numOf = int.Parse(Console.ReadLine());

			while (numOf <= 0)
			{
				Console.WriteLine("enter the number of slices of the second cake: ");
				numOf = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Enter othe taste rating rating(0 - 10): ");
			rating = int.Parse(Console.ReadLine());

			Cake cake2 = new Cake(type, numOf, rating);


			if (cake1.GetSlicesNumber() > cake2.GetSlicesNumber())
				Console.WriteLine(cake1.ToString());
			else if (cake1.GetSlicesNumber() < cake2.GetSlicesNumber())
				Console.WriteLine(cake2.ToString());
			else
				Console.WriteLine(cake1.ToString());



			Console.WriteLine("Enter the type of the thord cake: ");
			type = Console.ReadLine();
			Cake cake3 = new Cake(type);

			cake3.SetSlicesNumber(cake1.GetSlicesNumber() + cake2.GetSlicesNumber());
			
			if (cake1.GetTasteRating() + cake2.GetTasteRating() > 10)
				cake3.SetTasteRating(10);
			else
				cake3.SetTasteRating(cake1.GetTasteRating() + cake2.GetTasteRating());


			Console.WriteLine(cake3.ToString());

			if (cake1.GetCakeType() == "apple")
				Console.WriteLine(cake1.ToString());
			else if(cake2.GetCakeType() == "apple")
				Console.WriteLine(cake2.ToString());
			else if (cake3.GetCakeType() == "apple")
				Console.WriteLine(cake3.ToString());
			else
				Console.WriteLine("There is no appel cake.");


			while (cake1.IsMore() == true || cake2.IsMore() == true || cake3.IsMore() == true)
			{
				cake1.DecreaseSlicesNumber();
				cake2.DecreaseSlicesNumber();
				cake3.DecreaseSlicesNumber();
			}

			Console.WriteLine(cake1.ToString());
			Console.WriteLine(cake2.ToString());
			Console.WriteLine(cake3.ToString());

		}
	}
}
