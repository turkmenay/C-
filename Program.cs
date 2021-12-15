using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Girin :");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin :");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);

            
        }
    }
}
