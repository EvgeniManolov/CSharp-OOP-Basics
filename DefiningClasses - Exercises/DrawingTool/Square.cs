using System;

namespace DrawingTool
{
    public class Square
    {
        private int size;

        public Square(int size)
        {
            this.Size = size;
        }

        public int Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }

        public void Draw()
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (i == 0 || i == this.Size - 1)
                {
                    Console.WriteLine("|" + new string('-', this.Size) + "|");
                }
                else
                {
                    Console.WriteLine("|" + new string(' ', this.Size) + "|");
                }
            }
        }
    }
}
