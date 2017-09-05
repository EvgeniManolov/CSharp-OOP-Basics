namespace RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public double X
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public string Intersects(Rectangle rectangle)
        {
            if ((rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
                (rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X >= this.X && rectangle.X <= this.X + this.Width) ||
                (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
                (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X >= this.X && rectangle.X <= this.X + this.Width))
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}
