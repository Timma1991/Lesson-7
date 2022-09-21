using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Rectangle:Point
    {
        int width, height;
        public Rectangle() : this(5) { }
        public Rectangle(int width) : this(width, width) { }

        public Rectangle(int width, int height) : this(width, height, 0, 0) { }

        public Rectangle(int width, int height, int x, int y) : this(width, height, x, y, DEFAULT_COLOR) { }

        public Rectangle(int width, int height, int x, int y, ConsoleColor color): base(x, y, color)
        {
            this.width = width;
            this.height = height;
        }

        public double Square()
        {
            return Math.Abs(width) * Math.Abs(height);
        }
    }
}
