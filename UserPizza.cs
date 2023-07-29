using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class UserPizza
	{
		static void Main(string[] args)
		{
			Console.Write("Type your name: ");
			string name = Console.ReadLine();

			Console.Write("Type your phone number: ");
			string number = Console.ReadLine();

			Console.Write("Type the size of the pizza: ");
			char size = char.Parse(Console.ReadLine());

			Pizza p1 = new Pizza(name, number, size);

			Console.WriteLine("that kind of toppings you whant to add? (XXX)");
			string topp = Console.ReadLine();
			while (topp != "XXX")
			{
				p1.addTopping(topp);
				Console.WriteLine("that kind of toppings you whant to add? (XXX)");
				topp = Console.ReadLine();
			}

			Console.WriteLine();
			Console.WriteLine(p1.ToString());
		}

	}
}
