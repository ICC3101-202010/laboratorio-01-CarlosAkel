using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Yo = new Persona("Bob", "Kunga");
            Console.WriteLine(Yo.Lanzar());
            Console.WriteLine(Yo.MyName());


        }


    }
}
