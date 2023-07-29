using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
	internal class MagicCube
	{
		public static void Main(string[] args)
		{
			magicSquares();

		}

		//פעולה אשר יוצרת שני מערכים דו ממדים אחד הוא ריבוע הקסם והשני לא
		// הפעולה מדפיסה את שני הריבועים והאם כל אחד מהם הוא ריבוע כסם
		public static void magicSquares()
		{ 
			// מערכים של שני הריבועים
			int[,] firstSquare = { { 4, 3, 2, 1 }, { 1, 2, 3, 4 }, { 3, 4, 1, 2 }, { 2, 1, 4, 3 } };
			int[,] secondSquare = { { 1, 4, 5 }, { 2, 7, 6 }, { 3, 4, 1 } };


			// הדפסת הריבוע הראשון
			printArr(firstSquare);
			Console.WriteLine();
			Console.WriteLine(isMagicSquare(firstSquare));

			Console.WriteLine();

			// הדפסת הריבוע השני
			printArr(secondSquare);
			Console.WriteLine();
			Console.WriteLine(isMagicSquare(secondSquare));

		}

		// פעולה אשר מקבלת מערך דו ממדי ומדפיסה אותו
		public static void printArr(int[,] arr)
		{
			for (int i = 0; i<arr.GetLength(0); i++)
			{
				for (int j = 0; j<arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j]);
				}
				Console.ReadLine();
			}
		
		}

		// פעולה לקביעת האם המערך הדו ממדי שהיא מקבל הוא ריבוע כסם
		public static Boolean isMagicSquare(int[,] mat)
		{
			// בדיקה ראשונית האם מספר השורות והטורים שווה
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				if (mat.GetLength(0) != mat.GetLength(1))
				{
					return false;
				}
			}

			// בדיקה האם סכום של כל שורה וטור שווה לכל שאר הטורים והשורות
			int numOfCols = sumCol(mat, 0);
			int numOfRows = sumRow(mat, 0);
			for(int i = 1; i < mat.GetLength(0); i++)
			{
				if (numOfCols != sumCol(mat, i))
					return false;
				if(numOfRows != sumRow(mat, i))
					return false;
			}
			
			// בדיקה האם הסכומים של השורות והטורים שווים 
			if(numOfRows != numOfCols)
				return false;

			// בדיקה האם הסכומים של שני האלכסונים שווה
			if(sumPrimaryDiag(mat) != sumSecondaryDiag(mat))
				return false;

			// בדיקה האם סכום של האלכסונים שווה לסכומים של השורות והטורים
			if (sumPrimaryDiag(mat) != numOfCols)
				return false;
			
			// במידה והמערך הדו ממדי לא נפסל זה אומר שהוא ריבוע כסף 
			return true;

		}


		// פעולה שמקבלת מערך דו ממדי ומספר שורה ומחזירה את סכום המספרים בשורה הזו
		public static int sumCol(int[,] mat, int col)
		{
			int sum = 0;
			for (int i = 0; i < mat.GetLength(1); i++)
			{
				sum += mat[i, col];
			}
			return sum;

		}


		// פעולה שמקבלת מערך דו ממדי ומספר טור ומחזירה את סכום המספרים בטור הזו
		public static int sumRow(int[,] mat, int row)
		{
			int sum = 0;
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				sum += mat[row, i];
			}
			return sum;
		}

		// פעולה שמקבלת מערך דו ממדי  ומחזירה את סכום המספרים באלכסון הראשון הזו
		public static int sumPrimaryDiag(int[,] mat)
		{
			int sum = 0;
			for (int i = 0; i < mat.GetLength(1); i++)
			{
				sum += mat[i, i];
			}
			return sum;
		}

		// פעולה שמקבלת מערך דו ממדי  ומחזירה את סכום המספרים באלכסון השני הזו
		public static int sumSecondaryDiag(int[,] mat)
		{
			int sum = 0;
			int num = mat.GetLength(1) - 1;
			for (int i = 0; i < mat.GetLength(1); i++)
			{
				sum += mat[i, num - i];
			}
			return sum;
		}




	}
}
/*
	4321
	1234
	3412
	2143

	True

	145
	276
	341

	False
 
 
 
 
 */
