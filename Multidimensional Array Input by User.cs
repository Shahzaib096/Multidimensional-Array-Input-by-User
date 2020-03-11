using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array_Input_by_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Row Size :");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter Column Size :");
            int cols = int.Parse(Console.ReadLine());
            int[,] myArray = new int[rows, cols];
            //Array input values by User
            for(int row=0;row<rows;row++)
            {
                for(int col=0;col<cols;col++)
                {
                    Console.Write("Enter Elements {0} {1} = ",row,col);
                    myArray[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //Array Output 
            for(int row=0;row<myArray.GetLength(0);row++)
            {
                for(int col=0;col<myArray.GetLength(1);col++)
                {
                    Console.Write(" "+myArray[row,col]);
                }
                Console.WriteLine();
            }
            //Diagonal values
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    if(row==col )
                    {
                        Console.Write(myArray[row,col]);
                    }
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
