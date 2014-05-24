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
            var rn = new RomanNumerals();

            var romanNumeral = rn.GetRomanNumeral("1");

            Assert.AreEqual<string>("I", romanNumeral);
        
        }

        [TestMethod]
        public void When_I_Enter_2_App_Returns_II()
        {
            var rn = new RomanNumerals();

            var romanNumeral = rn.GetRomanNumeral("2");

            Assert.AreEqual<string>("II", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_5_App_Returns_V()
        {
            var rn = new RomanNumerals();

            var romanNumeral = rn.GetRomanNumeral("5");

            Assert.AreEqual<string>("V", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_30_App_Returns_XXX()
        {
            var rn = new RomanNumerals();

            var romanNumeral = rn.GetRomanNumeral("30");

            Assert.AreEqual<string>("XXX", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_37_App_Returns_XXXVII()
        {
            var rn = new RomanNumerals();

            var romanNumeral = rn.GetRomanNumeral("37");

            Assert.AreEqual<string>("XXXVII", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_40_App_Returns_XL()
        {
            var rn = new RomanNumerals();

            var romanNumeral = rn.GetRomanNumeral("40");

            Assert.AreEqual<string>("XL", romanNumeral);            
        }
    
    }
}
