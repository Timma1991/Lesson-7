namespace Figure
{
    internal class Circle : Point
    {
        private double radius;
        public Circle(double radius) : base()
        {
            this.radius = radius;
        }

        public Circle(int x, int y, double radius) : base(x, y)
        {
            this.radius = radius;
        }
        public Circle(int x, int y, ConsoleColor color, double radius) : base(x, y, color)
        {
            this.radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
