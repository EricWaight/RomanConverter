using System.Collections.Generic;
namespace RomanConverter
{
    public class RomanConverter
    {
        public int ConvertRomans(string roman)
        {
            //Variables
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            //Fill lookup dictionary
            lookup.Add('I', 1);
            lookup.Add('V', 5);
            lookup.Add('X', 10);
            lookup.Add('L', 50);
            lookup.Add('C', 100);
            lookup.Add('D', 500);
            lookup.Add('M', 1000);

            int integer = 0;
            int lastVal = 0;

            //Convert Romans to Integers
            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int value = lookup[roman[i]];

                if (value < lastVal){
                    integer -= value;
                }

                else 
                {
                    integer += value;
                    lastVal = value;
                }
            }
            return integer;

        }
    }
}
