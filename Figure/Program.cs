namespace Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.moveX(5);
            rect.moveY(10);
            rect.SetColor(ConsoleColor.Red);
        }
    }
}