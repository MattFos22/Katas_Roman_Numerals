namespace Kata_Roman_Numerals_Tests
{
    public interface ICharacterFoundListener
    {
        void NumericCharacterRequestedFound(string numberUnit, string romanNumeralToUse);
    }
}