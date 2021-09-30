using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] goodBands;

            goodBands = new string[] { "Papa Roach", "Ice Nine kills", "Memphis May Fire", "Metallica", "Avatar", "AC/DC", "Slayer", "D12" };



            string[] goodBandsCopy = new string[8];

            Array.Copy(goodBands, goodBands, 8);
            Console.WriteLine(goodBands[0]);
            Console.WriteLine(goodBands[1]);
            Console.WriteLine(goodBands[2]);
            Console.WriteLine(goodBands[3]);
            Console.WriteLine(goodBands[4]);
            Console.WriteLine(goodBands[5]);
            Console.WriteLine(goodBands[6]);
            Console.WriteLine(goodBands[7]);

            Array.Reverse(goodBands);
            Console.WriteLine(goodBands[0]);
            Console.WriteLine(goodBands[1]);
            Console.WriteLine(goodBands[2]);
            Console.WriteLine(goodBands[3]);
            Console.WriteLine(goodBands[4]);
            Console.WriteLine(goodBands[5]);
            Console.WriteLine(goodBands[6]);
            Console.WriteLine(goodBands[7]);

            Console.ReadKey();
        }
        static void Loops(string[] args)
        {
            bool buttonClick = false;
            int counter = 10;

            do
            {
                Console.WriteLine("Woah Not again");
                counter++;

                if (counter == 15)
                {
                    Console.WriteLine("Finally It's over");
                    break;
                }
            } while (!buttonClick);
        }
    }
}
