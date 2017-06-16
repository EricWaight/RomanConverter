using System;

namespace RomanConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take input
            Console.WriteLine("Please enter the Roman Numeral you would like to convert:");
            string romanNumeral = Console.ReadLine();

            //Initialize converter class
            RomanConverter converter = new RomanConverter();
           
            //Call convert function
            int integer = converter.ConvertRomans(romanNumeral);

            //Ouput
            Console.WriteLine(integer);
        }
    }
}
