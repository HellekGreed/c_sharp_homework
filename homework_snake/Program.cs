using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.SetBufferSize(120, 30);

            HorizontalLine lineUp = new HorizontalLine(0, 119, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 119, 29, '+');
            VerticalLine lineLeft = new VerticalLine(0, 0, 29, '+');
            VerticalLine lineRight = new VerticalLine(119, 0, 29, '+');
                       
            lineUp.Drow();
            lineDown.Drow();
            lineLeft.Drow();
            lineRight.Drow();
            
            Console.ReadLine();
        }
    }
}

