using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter your text");
            string value = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);
           
            Console.WriteLine("");
            Console.WriteLine("Enter the KEY");
        start: byte key = byte.Parse(Console.ReadLine());
            if (key < 1 || key > 25)
            {
                Console.WriteLine("Insert your KEY again");
                goto start;
            }
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i] += key;
                Console.Write((char)asciiBytes[i]);
            }
            Console.WriteLine();
            //for (int i = 0; i < asciiBytes.Length; i++)
            //{
            //    Console.Write(asciiBytes[i] + " ");
            //}
            Console.WriteLine("");
            Console.WriteLine("**************** Decoder ********************");
            ////////////// DECODE //////////////////
            Console.WriteLine("Enter your decode text");
            string decodeText = Console.ReadLine();
            Console.WriteLine("Enter your KEY to decode");
            byte decodeKey = byte.Parse(Console.ReadLine());
            byte[] asciiDecode = Encoding.ASCII.GetBytes(decodeText);
            Console.WriteLine("******** Ascii Code ********");
            for (int i = 0; i < asciiDecode.Length; i++)
            {
                asciiDecode[i] -= decodeKey;
            }
            Console.WriteLine();
            for (int i = 0; i < asciiDecode.Length; i++)
            {
                Console.Write((char)asciiDecode[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}