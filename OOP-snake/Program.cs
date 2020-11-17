﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace OOP_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(160, 50);

            Walls walls = new Walls(80, 25);
            walls.Draw();

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

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
