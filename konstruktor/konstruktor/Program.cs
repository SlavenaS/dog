using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Print();
            Console.Write("vuvedi godini ");
            Dog dog2 = new Dog(int.Parse(Console.ReadLine()));
            dog2.Print();
            Console.Write("vuvedi ime ");
            Dog dog3 = new Dog(int.Parse(Console.ReadLine()),Console.ReadLine());
            dog3.Print();
            Console.Write("vuvedi kg ");
            Dog dog4 = new Dog(int.Parse(Console.ReadLine()), Console.ReadLine(),double.Parse(Console.ReadLine()));
            dog4.Print();
            List<Dog>list = new List<Dog> { dog1, dog2, dog3, dog4 };

        }
    }
}
