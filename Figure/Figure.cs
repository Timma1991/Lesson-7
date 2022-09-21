namespace Figure
{
    abstract class Figure
    {
        protected Figure() : this(0, 0, ConsoleColor.White) { }
        protected Figure(int x, int y) : this(x, y, ConsoleColor.White) { }
        protected Figure(int x, int y, ConsoleColor color)
        {
            this._x = x;
            this._y = y;
            this._color = color;
        }

        protected const ConsoleColor DEFAULT_COLOR = ConsoleColor.White;
        private ConsoleColor _color;
        private bool _isVisible;
        protected int _x, _y;

        public void moveX(int offset)
        {
            _x += offset;
        }

        public void moveY(int offset)
        {
            _y += offset;
        }

        public void SetColor(ConsoleColor newColor)
        {
            _color = newColor;
        }

        public void SetVisible(bool isVisible)
        {
            this._isVisible = isVisible;
        }

        public bool IsVisible()
        {
            return _isVisible;
        }

        public override string ToString()
        {
            return $"Figure: color[{_color}]; X[{_x}]; Y[{_y}]; is visible[{_isVisible}]";
        }
    }
}
