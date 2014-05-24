using System.Collections.Generic;

namespace Kata_Roman_Numerals_Tests
{
    public interface INumericRules
    {
        Dictionary<string, string> NumericLookup { get; set; }  
    }
}