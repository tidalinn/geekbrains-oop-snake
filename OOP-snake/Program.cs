using System;
using System.Collections.Generic;
using System.Threading;

namespace OOP_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 80;
            int height = 25;
            int lineWidth = width - 2;
            int lineHeight = height - 2;

            Console.SetWindowSize(width, height);
            // set the window's size
            Console.SetBufferSize(width, height);

            // draw the framework
            HorizontalLine topLine = new HorizontalLine(0, lineWidth, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, lineWidth, lineHeight, '+');
            VerticalLine leftLine = new VerticalLine(0, lineHeight, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, lineHeight, lineWidth, '+');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // draw the dots
            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // create food
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
            }
        }
    }
}