namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set { this.length = value; }
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

        public double GetVolume()
        {
            return Length * Width * Height;
        }
        public double GetSurfaceArea()
        {
            return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        }
        public double GetLateralSurface()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }
    }
}
