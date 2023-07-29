using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class MagicSquare
    {
        public static Boolean isMagicSquare(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (mat.GetLength(0) != mat.GetLength(1))
                {
                    return false;
                }
            }

            int num1 = sumSecondaryDiag(mat);
            int num2 = sumPrimaryDiag(mat);
            int num3 = sumRow(mat, 0);
            int num4 = sumCol(mat, 0);


            for (int i = 1; i < mat.GetLength(0); i++)
            {
                if (num3 != sumRow(mat, i))
                {
                    return false;
                }
            }

            for (int i = 1; i < mat.GetLength(0); i++)
            {
                if (num4 != sumCol(mat, i))
                {
                    return false;
                }
            }

            if (num1 != num2 || num2 != num3 || num3 != num4)
            {
                return false;
            }
            return true;

        }



        public static int sumCol(int[,] mat, int col)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                sum += mat[i, col];
            }
            return sum;

        }


        public static int sumRow(int[,] mat, int row)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                sum += mat[row, i];
            }
            return sum;
        }

        public static int sumPrimaryDiag(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                sum += mat[i, i];
            }
            return sum;
        }

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
