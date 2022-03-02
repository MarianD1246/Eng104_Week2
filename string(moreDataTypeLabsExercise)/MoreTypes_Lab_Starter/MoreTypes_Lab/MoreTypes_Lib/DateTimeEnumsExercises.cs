using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }

    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (date < birthDate)
                throw new ArgumentException(String.Format("Error - birthDate is in the future"));
            return Convert.ToInt32(Math.Floor(((date - birthDate).Days / 365.25)));
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            switch (suit) 
            {
                case Suit.HEARTS:
                    return string.Format("You've broken my heart");
                case Suit.CLUBS:
                    return String.Format("And the seventh rule is if this is your first night at fight club, you have to fight.");
                case Suit.DIAMONDS:
                    return String.Format("Diamonds are a girls best friend");
                case Suit.SPADES:
                    return String.Format("Bucket and spade");
                default:
                    break;
            }
            return string.Empty;
        }
    }
}
