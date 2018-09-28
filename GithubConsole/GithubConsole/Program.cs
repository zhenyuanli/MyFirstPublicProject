using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int LX = int.Parse(inputs[0]); // the X position of the light of power
            int LY = int.Parse(inputs[1]); // the Y position of the light of power
            int TX = int.Parse(inputs[2]); // Thor's starting X position
            int TY = int.Parse(inputs[3]); // Thor's starting Y position

            int distanceX = LX - TX;
            int distanceY = LY - TY;

            int absoluteDistanceX = Math.Abs(distanceX);
            int absoluteDistanceY = Math.Abs(distanceY);

            string directionX = distanceX >= 0 ? "E" : "W";
            string directionY = distanceY >= 0 ? "S" : "N";

            // game loop
            while (absoluteDistanceX > 0 || absoluteDistanceY > 0)
            {
                int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                if (distanceY > 0 && distanceX > 0)
                {
                    Console.WriteLine(directionY + directionX);
                    absoluteDistanceX--;
                    absoluteDistanceY--;
                }
                else if (distanceY > 0 && distanceX <= 0)
                {
                    Console.WriteLine(directionY);
                    absoluteDistanceY--;
                }
                else if (distanceY <= 0 && distanceX > 0)
                {
                    Console.WriteLine(directionX);
                    absoluteDistanceX--;
                }
                
                Console.WriteLine("test for git");
                Console.WriteLine("test for git stage");
                Console.WriteLine("test for git diff");
                Console.WriteLine("test for git stash");
                Console.WriteLine("test for git stash");
                Console.WriteLine("test for git stash add");
                Console.WriteLine("test for git stash add");
                Console.WriteLine("test for git stash add");
            }
        }
    }
}
