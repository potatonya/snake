using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //boundaries
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            rightLine.Drew();
            leftLine.Drew();

            //dots
            Point p1 = new Point(2, 2, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.ReadKey();
        }
    }
}