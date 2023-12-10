using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3d__jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region mảng 3 chiều
            int[,,] a = new int[2,3,4]
            {
                { 
                    {1,3,5,2},
                    {2,5,2,2},
                    {1,2,3,4}
                },
                {
                    {3,2,5,1},
                    {3,5,2,1},
                    {4,3,1,5}
                }
            };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for ( int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.Write(a[i,j,k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion

            #region mảng jagged
            /*int[][] b = new int[3][];
            b[0] = new int[5];
            b[1] = new int[9];*/

            int[][] b = { new int[] {1,2,3},
                          new int[] {4,5,6}};

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j]);
                }
                Console.WriteLine();
            }
            #endregion
            Console.ReadKey();
        }
    }
}
