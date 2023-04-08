using System.Data;
using System.Globalization;

namespace _15_Lattice_paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 21;
            int column = 21;

            //zalozenie matice 21 x 21
            long[,] matrix = new long[row, column];
            

            for (int x = 0; x < row; x++)
            {
                matrix[x, 0] = 1;
            }

            for (int y = 0; y < column; y++)
            {
                matrix[0, y] = 1;
            }

            for (int x = 1; x < row; x++)
            {
                for (int y = 1; y < column; y++)
                {
                    matrix[x, y] = matrix[x - 1, y] + matrix[x, y - 1];
                }
            }
            Console.WriteLine(matrix[20, 20]);
        }
    }
}