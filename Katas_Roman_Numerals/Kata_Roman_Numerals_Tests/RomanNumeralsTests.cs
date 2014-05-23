using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_Roman_Numerals_Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void When_I_Enter_1_App_Returns_I()
        {
            RomanNumerals rn = new RomanNumerals();

            string romanNumeral = rn.GetRomanNumeral("1");

            Assert.AreEqual<string>("I", romanNumeral);
        
        }

        [TestMethod]
        public void When_I_Enter_2_App_Returns_II()
        {
            RomanNumerals rn = new RomanNumerals();

            string romanNumeral = rn.GetRomanNumeral("2");

            Assert.AreEqual<string>("II", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_5_App_Returns_V()
        {
            RomanNumerals rn = new RomanNumerals();

            string romanNumeral = rn.GetRomanNumeral("5");

            Assert.AreEqual<string>("V", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_30_App_Returns_XXX()
        {
            RomanNumerals rn = new RomanNumerals();

            string romanNumeral = rn.GetRomanNumeral("30");

            Assert.AreEqual<string>("XXX", romanNumeral);
        }
    }
}
