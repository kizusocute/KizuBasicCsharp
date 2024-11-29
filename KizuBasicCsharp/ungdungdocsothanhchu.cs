using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KizuBasicCsharp
{
    public static class ungdungdocsothanhchu
    {
        public static void run()
        {
            Console.WriteLine("Nhập một số nguyên không âm (tối đa 3 chữ số):");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999)
            {
                Console.WriteLine("out of ability");
                return;
            }

            Console.WriteLine(NumberToWords(number));
            Console.ReadLine();
        }
        public static string NumberToWords(int num)
        {
            if (num < 10)
                return ReadSingleDigit(num); 
            else if (num < 20)
                return ReadTeens(num); 
            else if (num < 100)
                return ReadTens(num); 
            else
                return ReadHundreds(num); 
        }

        // Đọc các số có một chữ số
        public static string ReadSingleDigit(int num)
        {
            switch (num)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }

        // Đọc các số từ 10 đến 19
        public static string ReadTeens(int num)
        {
            switch (num)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default: return "";
            }
        }

        // Đọc các số từ 20 đến 99
        static string ReadTens(int num)
        {
            int tens = num / 10;
            int ones = num % 10;

            string tensWord = "";
            switch (tens)
            {
                case 2: tensWord = "twenty"; break;
                case 3: tensWord = "thirty"; break;
                case 4: tensWord = "forty"; break;
                case 5: tensWord = "fifty"; break;
                case 6: tensWord = "sixty"; break;
                case 7: tensWord = "seventy"; break;
                case 8: tensWord = "eighty"; break;
                case 9: tensWord = "ninety"; break;
            }

            if (ones == 0)
                return tensWord;
            else
                return $"{tensWord} {ReadSingleDigit(ones)}";
        }

        // Đọc các số từ 100 đến 999
        static string ReadHundreds(int num)
        {
            int hundreds = num / 100;
            int remainder = num % 100;

            string hundredsWord = $"{ReadSingleDigit(hundreds)} hundred";

            if (remainder == 0)
                return hundredsWord;
            else
                return $"{hundredsWord} and {NumberToWords(remainder)}";
        }
    }
}
