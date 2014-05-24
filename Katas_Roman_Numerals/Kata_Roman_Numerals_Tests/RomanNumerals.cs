using System.Linq;
using System.Text;

namespace Kata_Roman_Numerals_Tests
{
    public class RomanNumerals
    {
        public int NumberOfOnes;
        public int NumberOfFives;
        public int NumberOfTens;
        public int NumberOfHundreds;
        public string RomanNumeral;
        public INumericRules NumericalRules;
        private readonly ICharacterFoundListener _listener;

        public RomanNumerals(ICharacterFoundListener listener)
        {
            _listener = listener;
        }

        public string GetCharactersFromNumberType(string numberUnit, int number)
        {
            //put loop around
            string returnCharacter = NumericLookup[numberUnit];
            _listener.NumericCharacterRequestedFound(numberUnit);
            // to here
            return returnCharacter;
        }

        internal string GetRomanNumeral(string p)
        {
            ChunkNumbers(p);

            GetCharactersFromNumberType("Ones", NumberOfOnes);

            //if(NumberOfHundreds > 0)
            //{
            //    AppendToString(NumberOfHundreds, "C");
            //}
            //if(NumberOfTens > 0)
            //{
            //    AppendToString(NumberOfTens, "X");                           
            //}
            //if(NumberOfFives > 0)
            //{
            //    AppendToString(NumberOfFives, "V");
            //}
            //if(NumberOfOnes > 0)
            //{
            //    AppendToString(NumberOfOnes, "I");
            //}

            return RomanNumeral;
        }

        #region Assembly
        private void AppendToString(int numberOfAppends, string romanCharacterToAppend)
        {
            var sb = new StringBuilder();
            for(var i = 0; i < numberOfAppends; i++)
            {
                sb.Append(romanCharacterToAppend);
            }

            RomanNumeral += sb;
        }

        private void ChunkNumbers(string strNumber)
        {
            int originalNumber;
            int.TryParse(strNumber, out originalNumber);

            NumberOfHundreds = originalNumber / 100;
            NumberOfTens = (originalNumber - (NumberOfHundreds * 100)) / 10; 
            int tempNumber = (originalNumber - (NumberOfHundreds * 100));
            tempNumber = (tempNumber - (NumberOfTens * 10));
            NumberOfFives = (tempNumber / 5);
            tempNumber = ((NumberOfFives > 0) ? tempNumber - 5 : tempNumber);

            NumberOfOnes = tempNumber;
        }
        #endregion

    }
}
