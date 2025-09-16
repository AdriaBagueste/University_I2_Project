namespace Consola_1
{
    internal class Program
    {
        static float Getfloat(int n)
        {
            float Float_Number = n;

            return Float_Number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine((Getfloat(10).GetType()));
         
        }

    }
}