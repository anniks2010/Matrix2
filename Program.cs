using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] matrix =
            {
                new int []{1,2,3}, ///row 0
                new int []{4,5,6}, ///row 1
                new int []{7,8,9} /// row 2
            };

            Console.WriteLine(matrix[1][1]);

            ///Main diagonal 1,5,9
            for (int i =0; i< matrix.Length; i++)
            {
                Console.Write(matrix[i][i]);
            }
            Console.WriteLine();
            ////Second diagonal 3,5,7
            for (int i =0; i < matrix.Length; i++)
            {
                Console.Write(matrix[i][matrix.Length - 1 -i]);
            }
            Console.WriteLine();
            ////Get diagonals: a) 7,5,3 
            for (int i = 2; i>= matrix.Length-3; i--)
            {   
                Console.Write(matrix[i][matrix.Length-1-i]);
            }
            Console.WriteLine();
            ////Get diagonals: b) 9,5,1
            for (int i =2; i>= matrix.Length-3; i--)
            {
                Console.Write(matrix[i][i]);
            }

            Console.ReadKey();

        }
    }
}
