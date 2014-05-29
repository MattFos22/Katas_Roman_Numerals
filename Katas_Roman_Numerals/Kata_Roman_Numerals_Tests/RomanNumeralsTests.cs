using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_Roman_Numerals_Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void When_I_Enter_1_App_Returns_I()
        {
            var presenter = new RomanNumeralPresenter();

            var romanNumeral = presenter.GetRomanNumerals("1");

            Assert.AreEqual<string>("I", romanNumeral);
        
        }

        [TestMethod]
        public void When_I_Enter_2_App_Returns_II()
        {
            var presenter = new RomanNumeralPresenter();

            var romanNumeral = presenter.GetRomanNumerals("2");

            Assert.AreEqual<string>("II", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_5_App_Returns_V()
        {
            var presenter = new RomanNumeralPresenter();

            var romanNumeral = presenter.GetRomanNumerals("5");

            Assert.AreEqual<string>("V", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_30_App_Returns_XXX()
        {
            var rn = new RomanNumeralPresenter();

            var romanNumeral = rn.GetRomanNumerals("30");

            Assert.AreEqual<string>("XXX", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_4_App_Returns_IV()
        {

            var chunker = new RomanNumeralChunker("4"); // fix this - shouldnt be processing before the presenter calls
            var presenter = new RomanNumeralPresenter(chunker, );
            var characterExceptions = new RomanCharacterRuleExceptionManager(presenter);
            var characterSet = new RomanNumeralCharacterSet();
            var getter = new RomanNumeralGetter(characterExceptions, characterSet);


            


            var romanNumeral = presenter.GetRomanNumerals("4");

            Assert.AreEqual<string>("IV", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_37_App_Returns_XXXVII()
        {
            var rn = new RomanNumeralPresenter();

            var romanNumeral = rn.GetRomanNumerals("37");

            Assert.AreEqual<string>("XXXVII", romanNumeral);
        }

        [TestMethod]
        public void When_I_Enter_40_App_Returns_XL()
        {
            var rn = new RomanNumeralPresenter();

            var romanNumeral = rn.GetRomanNumerals("40");

            Assert.AreEqual<string>("XL", romanNumeral);            
        }
    
    }
}
