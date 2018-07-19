using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {
                //greeting and prompt
                Console.WriteLine("Hello user! I am a squares and cubes calculator!");
                Console.WriteLine("Please input an integer and I will print the squares and cubes from 1 to that integer.");
                string userNum = Console.ReadLine();

                //is int or num check
                long userInt;
                bool num1 = long.TryParse(userNum, out userInt);
                if (!(num1))
                {
                    Console.WriteLine("Input is not a integer");
                }
                
                //making the grid
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "=======", "=======", "======="));
               
                //easy math w/o math function
                //Write results to grid
                long i = 1;
                while (i <= userInt)
                {
                    long numSquare = i * i;
                    long numCubed = i * i * i;

                    long[] number = {i++};
                    long[] squared = {numSquare};
                    long[] cubed = {numCubed};
                    
                    for (long index = 0; index < number.Length; index++)
                    {
                        Console.WriteLine(String.Format("{0,-10} {1,-10} {2, -10}", number[index], squared[index], cubed[index]));
                    }
                }
                
                    //continue y/n
                    bool invalid = true;
                    while (invalid)
                    {
                        Console.WriteLine("Continue? (y/n):");
                        ConsoleKeyInfo pressed = Console.ReadKey();
                        Console.WriteLine();
                        bool isY = pressed.Key == ConsoleKey.Y;
                        bool isN = pressed.Key == ConsoleKey.N;

                        invalid = !isY && !isN;
                        y = isY;

                    }       
            }
        }
    }
}
