using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class Pizza
	{
		private string name;	
		private string phoneNom;	
		private char size;	
		private int price;	
		private int numOfTopping;  
		private string[] arrtoppings;

		private const int smallPrice = 35;
		private const int MediumPrice = 45;
		private const int largePrice = 55;
		private const int toppingPrice = 2;
		

		public Pizza(string name, string phoneNom, char size) 
		{
			this.name = name;
			this.phoneNom = phoneNom;
			this.size = size;
			this.arrtoppings = new string[8];
			this.numOfTopping = 0;
		}

		public void addTopping(string topping)
		{
			arrtoppings[this.numOfTopping] = topping; 
			this.numOfTopping++;
		}

		public int Price()
		{ 
			int price = 0;
			switch (this.size)
			{
				case 'S': price = smallPrice;
					break;

				case 'M': price = MediumPrice;
					break;

				case 'L': price = largePrice;
					break;
			}
			price += this.numOfTopping * toppingPrice;
			return price;
		}


		public override string ToString()
		{
			string str = "name: " + this.name + "\t phone: " + this.phoneNom + "\n";
			str += "You orderd a pizza size " + this.size + "\n";
			
			if (this.numOfTopping == 0)
				str += "no toppings \n";
			else
			{
				str += "Your topping: ";
				for (int i = 0; i < this.numOfTopping; i++)
				{
					str += this.arrtoppings[i];
					if(i < this.numOfTopping - 1)
						str += ",";
				}

			}
			str += "\n";
			str += $"Your price is {Price()}";
			return str;
		}






	}
}
