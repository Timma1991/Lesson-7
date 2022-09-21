using System;
using System.Collections.Generic;
namespace Figure
{
    class Point : Figure
    {
        public Point(int x, int y) : base(x, y) { }

        public Point(int x, int y, ConsoleColor color) : base(x, y, color) { }

        public Point() : base() { }
    }
}
