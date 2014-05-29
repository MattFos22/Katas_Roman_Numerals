namespace Kata_Roman_Numerals_Tests
{
    public class RomanCharacterRuleExceptionManager : ICharacterFoundListener
    {        
        private readonly ICharacterExceptionListener _listener;
        private int _onesAmount;
        private int _fivesAmount;
        private int _tensAmount;

        public RomanCharacterRuleExceptionManager(ICharacterExceptionListener listener)
        {
            _listener = listener;
        }

        public void NumericCharacterRequestedFound(string numberUnit, string romanNumeralInUse)
        {
            switch (numberUnit)
            {
                case "Ones":
                    _onesAmount ++;
                    RaiseCharacterSetRuleExceptions();
                    break;
                case "Fives":
                    _fivesAmount ++;
                    RaiseCharacterSetRuleExceptions();                    
                    break;
                case "Tens":
                    _tensAmount ++;
                    RaiseCharacterSetRuleExceptions();
                    break;
            }
        }

        private void RaiseCharacterSetRuleExceptions()
        {
            // hard coded for now but copuld be made more generic for other number sets
            if (_onesAmount == 4 && _fivesAmount == 1)
            {
                _listener.CharacterSetRuleExceptionTriggered("IX");
            }
            if (_onesAmount == 4 && _fivesAmount == 0)
            {
                _listener.CharacterSetRuleExceptionTriggered("IV");                
            }
        }
    }
}