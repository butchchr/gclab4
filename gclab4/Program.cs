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
                Console.WriteLine("Hello user! I am a squares and cubes calculator!");
                Console.WriteLine("Please input an integer and I will print the squares and cubes from 1 to that integer.");
                string userNum = Console.ReadLine();

                int userInt;
                bool num1 = int.TryParse(userNum, out userInt);
                if (!(num1))
                {
                    Console.WriteLine("Input is not a integer");
                }
                int i = 1;
                while (i <= userInt)
                {
                    int numSquare = i * i;
                    int numCubed = i * i * i;

                    int [] number = {i++};
                    int [] squared = {numSquare};
                    int[] cubed = {numCubed};
                    String s = String.Format("{0,-10} {1,-10} {2,-10}\n\n", "Number", "Squared", "Cubed");
                    for (int index = 0; index < number.Length; index++)
                    {
                        s += String.Format("{0,-10} {1,-10:N0} {2, -10:N0}\n", number[index], squared[index], cubed[index]);
                        Console.WriteLine($"\n{s}");
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
