using System;
using System.Net;

namespace Test_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();

            int a = rec.Aeria();
            Console.WriteLine("Aeria de Rectangle est: " + a);

            rec.Height = 45;
            rec.Lenght = 60;
            int b = rec.Aeria();
            Console.WriteLine("Aeria de Rectangle est: " + b);

        }
    }
}
