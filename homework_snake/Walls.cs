using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWigth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine lineUp = new HorizontalLine(0, mapWigth - 2, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, mapWigth - 2, mapHeight - 1, '+');
            VerticalLine lineLeft = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine lineRight = new VerticalLine(mapWigth - 2, 0, mapHeight - 1, '+');
            
            wallList.Add(lineUp); 
            wallList.Add(lineDown);
            wallList.Add(lineLeft);
            wallList.Add(lineRight);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
