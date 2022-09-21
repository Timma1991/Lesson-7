namespace Decoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoder coder = new ACoder();
            string encoded = coder.Encode("ilya");
            Console.WriteLine(encoded);
            Console.WriteLine("Hello, World!");
        }
    }
}