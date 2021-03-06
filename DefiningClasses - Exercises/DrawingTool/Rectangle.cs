﻿using System;

namespace DrawingTool
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                if (i == 0 || i == this.Height - 1)
                {
                    Console.WriteLine("|" + new string('-', this.Width) + "|");
                }
                else
                {
                    Console.WriteLine("|" + new string(' ', this.Width) + "|");
                }
            }
        }
    }
}
