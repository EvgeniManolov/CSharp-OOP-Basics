using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radious;

        public Circle(double radious)
        {
            this.Radious = radious;
        }

        public double Radious
        {
            get { return this.radious; }
            private set { this.radious = value; }
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Radious * this.Radious;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radious;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}

