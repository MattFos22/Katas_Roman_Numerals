using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Roman_Numerals_Tests
{
    class RomanNumerals
    {
        public int numberOfOnes;
        public int numberOfFives;
        public int numberOfTens;
        public int numberOfHundreds;
        public string romanNumeral;

        public RomanNumerals()
        {

        }

        internal string GetRomanNumeral(string p)
        {
            ChunkNumbers(p);

            if(numberOfHundreds > 0)
            {
                appendToString(numberOfHundreds, "C");
            }
            if(numberOfTens > 0)
            {
                appendToString(numberOfTens, "X");
            }
            if(numberOfFives > 0)
            {
                appendToString(numberOfFives, "V");
            }
            if(numberOfOnes > 0)
            {
                appendToString(numberOfOnes, "I");
            }

            return romanNumeral;
        }

        private void appendToString(int numberOfAppends, string romanCharacterToAppend)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < numberOfAppends; i++)
            {
                sb.Append(romanCharacterToAppend);
            }

            romanNumeral += sb;
        }

        private void ChunkNumbers(string strNumber)
        {
            int originalNumber;
            int.TryParse(strNumber, out originalNumber);
            int tempNumber;

            numberOfHundreds = originalNumber / 100;
            numberOfTens = (originalNumber - (numberOfHundreds * 100)) / 10; 
            tempNumber = (originalNumber - (numberOfHundreds * 100));
            tempNumber = (tempNumber - (numberOfTens * 10));
            numberOfFives = (tempNumber / 5);
            tempNumber = ((numberOfFives > 0) ? 5 : 0);

            numberOfOnes = tempNumber;
        }
    }
}
