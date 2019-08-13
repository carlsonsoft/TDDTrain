using System;

namespace GameNumber
{
    public class FizzBuzz
    {
        public static string At(int position)
        {
            var result = "";
            if (position % 3 == 0 || position.ToString().Contains("3"))
            {
                result += "Fizz";
            }
            if (position % 5 == 0 || position.ToString().Contains("5"))
            {
                result += "Buzz";
            }

            if (result == "")
            {
                result += position;
            }
            return result;
        }

        private static bool IsDividedBy(int position, int divided)
        {
            return position % divided == 0;
        }
    }
}
