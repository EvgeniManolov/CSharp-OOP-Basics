using System;

namespace DrawingTool
{
    public class StartUp
    {
        public static void Main()
        {
            string command;

            if ((command = Console.ReadLine()) == "Square")
            {
                int size = int.Parse(Console.ReadLine());
                CorDraw cor = new CorDraw(new Square(size));
                cor.Square.Draw();
            }
            else if (command == "Rectangle")
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                CorDraw cor = new CorDraw(new Rectangle(width, height));
                cor.Rectangle.Draw();
            }
        }
    }
}
