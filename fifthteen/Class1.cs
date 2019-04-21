using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifthteen
{
    class Class1
    {
        public int size;
        public int zeroX;
        public int zeroY;
        public int[,] mass;
        public Random rnd = new Random();
        public int currentX;
        public int currentY;
        public Class1(int size)
        {
            if (size < 2)
            {
                size = 2;
            }
            if (size > 5)
            {
                size = 5;
            }
            this.size = size;
            mass = new int[size, size];
        }
        public void Start()
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    mass[y, x] = CoordsToPosition(x, y) + 1; 
                }
            }
            zeroX = rnd.Next(0,3);
            zeroY = rnd.Next(0, 3);
            mass[zeroX,zeroY] = 0;
            mass[3, 3] = CoordsToPosition(zeroY, zeroX) + 1;
        }
        public int CoordsToPosition(int x, int y)
        {
            return y * size + x;
        }
        public void PositionToCoords(int position, out int x, out int y)
        {
            x = position % size;
            y = position / size;
        }
        public  int FindOutCurrentYPosition()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mass[i, j] == 0)
                    {
                        
                        currentY = i;
                        break;

                    }
                }
            }
            return currentY;
        }
        public  int FindOutCurrentXPosition()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mass[i, j] == 0)
                    {
                        currentX = j;
                        break;
                    }
                }
            }
            return currentY;
        }
    }
}
