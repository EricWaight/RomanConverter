using System;
using RomanConverter;

namespace RomanConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Roman Numeral you would like to convert:");
            string romanNumeral = Console.ReadLine();

            RomanConverter converter = new RomanConverter();
           
            int integer = converter.ConvertRomans(romanNumeral);

            Console.WriteLine(integer);
        }
    }
}
