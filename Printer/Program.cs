namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Color printer = new Color();
            printer.Print("1");
            printer.Print("2");
        }
    }
}