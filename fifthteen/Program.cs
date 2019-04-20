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
        public static List<int> positions = new  List<int>();
        public static int Variator = game.rnd.Next(0, 3);
  
        public static void SwapUp()
        {
            int v;
            game.FindOutCurrentXPosition();
            game.FindOutCurrentYPosition();
            if (game.currentY > 0)
            {
                v = game.mass[game.currentY - 1, game.currentX];
                game.mass[game.currentY - 1, game.currentX] = game.mass[game.currentY, game.currentX];
                game.mass[game.currentY, game.currentX] = v;
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
                game.mass[game.currentY + 1, game.currentX] = game.mass[game.currentY, game.currentX];
                game.mass[game.currentY, game.currentX] = v;
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
                game.mass[game.currentY, game.currentX -1] = game.mass[game.currentY, game.currentX];
                game.mass[game.currentY, game.currentX] = v;
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
                game.mass[game.currentY, game.currentX + 1] = game.mass[game.currentY, game.currentX];
                game.mass[game.currentY, game.currentX] = v;
            }

        }
        public static void Shufle()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    foreach (int item in positions)
                    {
                        if (game.mass[i, j] == item)
                        {
                            for (int k = 0; k < 50; k++)
                            {
                                switch (Variator)
                                {
                                    case 0:
                                        SwapUp();
                                        break;
                                    case 1:
                                        SwapDown();
                                        break;
                                    case 2:
                                        SwapLeft();
                                        break;
                                    case 3:
                                        SwapRight();
                                        break;
                                }
                            }
                            break;
                        }
                    }
                }
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
            for (int i = 0; i < 16; i++)
            {
                positions.Add(i);
            }
            game.Start();
            Shufle();
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
