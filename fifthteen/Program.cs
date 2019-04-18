using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifthteen
{
    class Program
    {
        public static Class1 game = new Class1(4);
  
        public static void SwapUp()
        {
            int v;
            game.FindOutCurrentXPosition();
            game.FindOutCurrentYPosition();
            if (game.currentY > 0)
            {
                v = game.mass[game.currentY - 1, game.currentX];
                game.mass[game.currentY, game.currentX] = v;
                game.mass[game.currentY - 1, game.currentX] = 0;
            }
            
        }
        public static void SwapDown()
        {
            int v;
            game.FindOutCurrentXPosition();
            game.FindOutCurrentYPosition();
            if (game.currentY < 3)
            {
                v = game.mass[game.currentY + 1, game.currentX];
                game.mass[game.currentY, game.currentX] = v;
                game.mass[game.currentY + 1, game.currentX] = 0;
            }
            
        }
        public static void SwapLeft()
        {
            int v;
            game.FindOutCurrentXPosition();
            game.FindOutCurrentYPosition();
            if (game.currentX > 0)
            {
                v = game.mass[game.currentY, game.currentX-1];
                game.mass[game.currentY, game.currentX] = v;
                game.mass[game.currentY, game.currentX-1] = 0;
            }

        }
        public static void SwapRight()
        {
            int v;
            game.FindOutCurrentXPosition();
            game.FindOutCurrentYPosition();
            if (game.currentX < 3)
            {
                v = game.mass[game.currentY, game.currentX + 1];
                game.mass[game.currentY, game.currentX] = v;
                game.mass[game.currentY, game.currentX + 1] = 0;
            }

        }
        public static void Render()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                    Console.Write($"{game.mass[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        

        static void Main(string[] args)
        {
            game.Start();
            Console.WriteLine(game.mass[0, 0]);
            Console.WriteLine(game.mass[0, 1]);
            Console.WriteLine(game.mass[0, 2]);
            Console.WriteLine(game.mass[0, 3]);
            Console.WriteLine(game.mass[1, 0]);
            Console.WriteLine(game.mass[1, 1]);
            Console.WriteLine(game.mass[1, 2]);
            Console.WriteLine(game.mass[1, 3]);
            Console.WriteLine(game.mass[2, 0]);
            Console.WriteLine(game.mass[2, 1]);
            Console.WriteLine(game.mass[2, 2]);
            Console.WriteLine(game.mass[2, 3]);
            Console.WriteLine(game.mass[3, 0]);
            Console.WriteLine(game.mass[3, 1]);
            Console.WriteLine(game.mass[3, 2]);
            Console.WriteLine(game.mass[3, 3]);
            Render();
            Console.WriteLine("Input wasd");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "w":
                        SwapUp();
                        Render();
                        break;
                        case "s":
                        SwapDown();
                        Render();
                        break;
                        case "a":
                        SwapLeft();
                        Render();
                        break;
                        case "d":
                        SwapRight();
                        Render();
                        break;
                }
            }

            
            

            
            Console.ReadKey();
        }
    }
}
