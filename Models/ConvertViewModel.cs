using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TechnologyOneTest.Models
{
    public class ConvertModel
    {
        public decimal InputNumber { get; set; }
        public string? Result { get; set; }

        private readonly Dictionary<int, string> UnitsMap = new()
        {
            { 0, "ZERO" }, 
            { 1, "ONE" }, 
            { 2, "TWO" }, 
            { 3, "THREE" },
            { 4, "FOUR" }, 
            { 5, "FIVE" }, 
            { 6, "SIX" }, 
            { 7, "SEVEN" },
            { 8, "EIGHT" }, 
            { 9, "NINE" }, 
            { 10, "TEN" }, 
            { 11, "ELEVEN" },
            { 12, "TWELVE" }, 
            { 13, "THIRTEEN" }, 
            { 14, "FOURTEEN" },
            { 15, "FIFTEEN" }, 
            { 16, "SIXTEEN" }, 
            { 17, "SEVENTEEN" },
            { 18, "EIGHTEEN" }, 
            { 19, "NINETEEN" }
        };

        private readonly Dictionary<int, string> TensMap = new()
        {
            { 2, "TWENTY" }, 
            { 3, "THIRTY" }, 
            { 4, "FORTY" },
            { 5, "FIFTY" }, 
            { 6, "SIXTY" }, 
            { 7, "SEVENTY" },
            { 8, "EIGHTY" }, 
            { 9, "NINETY" }
        };

        public string ConvertNumberToWords()
        {
            string text = "";

            try
            {
                var wholeNumber = (int)InputNumber;
                var fraction = (int)((InputNumber - wholeNumber) * 100);

                if (wholeNumber < 0)
                {
                    text = "MINUS ";
                    wholeNumber = Math.Abs(wholeNumber);
                    fraction = Math.Abs(fraction);
                }

                text += ConvertToWords(wholeNumber) + " DOLLAR" + (wholeNumber == 1 ? "" : "S");

                if (fraction != 0)
                    text += " AND " + ConvertToWords(fraction) + " CENTS";

                return text.ToUpper();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        private string ConvertToWords(int number)
        {
            if (number == 0) 
                return UnitsMap[0];

            string text = "";

            //adds numbers in chunks by recursively passing over it again with the value
            if ((number / 1000000000) > 0)
            {
                text += ConvertToWords(number / 1000000000) + " BILLION ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                text += ConvertToWords(number / 1000000) + " MILLION ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                text += ConvertToWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                text += ConvertToWords(number / 100) + " HUNDRED ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    text += UnitsMap[number];
                else
                {
                    text += TensMap[number / 10];
                    int units = number % 10;
                    if (units > 0)
                        text += "-" + UnitsMap[units];
                }
            }

            return text.Trim();
        }
    }
}