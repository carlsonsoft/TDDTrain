using System;

namespace GameNumber
{
    public class GameNumber
    {
        private readonly int _value;

        public GameNumber(int value)
        {
            this._value = value;
        }

        public string Say()
        {
            if (Divide(3) == 0 && Divide(5) == 0)
            {
                return "FizzBuzz";
            }
            if (Divide(3) == 0 || _value.ToString().Contains("3"))
            {
                return "Fizz";
            }

            if (Divide(5) == 0 || _value.ToString().Contains("5"))
            {
                return "Buzz";
            }
            return _value.ToString();
        }

        private int Divide(int v)
        {
            return _value % v;
        }

    }
}
