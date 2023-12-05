using System;

namespace homework11
{
    [DeveloperInfo("Пушкин")]
    internal class Rational
    {
        private long numerator;
        private long denominator;
        public Rational(long numerator, long denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            Console.WriteLine($"{numerator}/{denominator}");
            return ($"{numerator}/{denominator}");
        }
    }
}