namespace DrawingTool
{
    public class CorDraw
    {

        private Rectangle rectangle;
        private Square square;

        public CorDraw(Rectangle rectangle)
        {
            this.Rectangle = rectangle;
        }

        public CorDraw(Square square)
        {
            this.Square = square;
        }

        public Rectangle Rectangle
        {
            get { return this.rectangle; }
            private set { this.rectangle = value; }
        }

        public Square Square
        {
            get { return this.square; }
            private set { this.square = value; }
        }
    }
}
