using System;
using System.Collections.Generic;

namespace OOP_snake
{
	class Program
	{
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            // чтобы в переменную i на каждом витке цикла были поочерёдно записаны значения всех элементов списка
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            // homework
            Point p3 = new Point(7, 10, '%');
            p3.Draw();

            Point p4 = new Point(10, 6, '$');
            p4.Draw();

            Point p5 = new Point(13, 8, '@');
            p5.Draw();

            Point p6 = new Point(15, 20, '&');
            p6.Draw();

            List<Point> pListHomework = new List<Point>();
            pListHomework.Add(p3);
            pListHomework.Add(p4);
            pListHomework.Add(p5);
            pListHomework.Add(p6);

            Console.ReadLine();
        }
    }
}
