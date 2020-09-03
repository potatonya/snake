﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;

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
            rightLine.Drow();
            leftLine.Drow();

            //dots
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}