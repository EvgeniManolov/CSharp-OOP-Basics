﻿using System;
using System.Linq;

namespace RectangleIntersection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] numbersOfRectangles = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Rectangle[] rectangles = new Rectangle[numbersOfRectangles[0]];

            for (int i = 0; i < numbersOfRectangles[0]; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = tokens[0];
                double width = double.Parse(tokens[1]);
                double height = double.Parse(tokens[2]);
                double x = double.Parse(tokens[3]);
                double y = double.Parse(tokens[4]);

                rectangles[i] = new Rectangle(id, width, height, x, y);
            }

            for (int i = 0; i < numbersOfRectangles[1]; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                Rectangle rect1 = rectangles.Where(r => r.Id == tokens[0]).First();
                Rectangle rect2 = rectangles.Where(r => r.Id == tokens[1]).First();
                Console.WriteLine(rect1.Intersects(rect2));
            }
        }
    }
}
