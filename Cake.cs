using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class Cake
	{
		private string cakeType;
		private int slicesNumber;
		private int tasteRating;
		public Cake(string cakeType, int slicesnumber, int tasteRating) 
		{
			this.cakeType = cakeType;
			this.slicesNumber = slicesnumber;
			this.tasteRating = tasteRating;
		}

		public Cake(string cakeType)
		{ 
			slicesNumber=0;
			this.tasteRating=0;
		}

		public string GetCakeType()
		{ 
			return this.cakeType;
		}

		public int GetSlicesNumber() 
		{
			return this.slicesNumber;
		}

		public int GetTasteRating()
		{
			return this.tasteRating;
		}

		public void SetCakeType(string cakeType)
		{ 
			this.cakeType= cakeType;
		}

		public void SetSlicesNumber(int slicesnumber) 
		{ 
			this.slicesNumber = slicesnumber;
		}

		public void SetTasteRating(int testeRating)
		{
		
			this.tasteRating = testeRating;
		}

		public void DecreaseSlicesNumber()
		{
			if(this.slicesNumber > 0)
				this.slicesNumber--;
		}

		public bool IsMore()
		{ 
			if(this.slicesNumber > 0)
				return true;
			return false;
		}

		public override string ToString()
		{
			return ($"Cake Type is {this.cakeType}, number of slices is {this.slicesNumber}, taste rating is {this.tasteRating}");
		}

	}
}
