namespace GameNumber
{
    public class GameNumber
    {
        private readonly int _position;
        public GameNumber(int position)
        {
            this._position = position;
        }
        public string Say()
        {
            if (IsSpecialPosition(3) && IsSpecialPosition(5))
            {
                return "FizzBuzz";
            }
            if (IsSpecialPosition(3))
            {
                return "Fizz";
            }
            if (IsSpecialPosition(5))
            {
                return "Buzz";
            }
            
            return _position.ToString();
        }
        private bool IsSpecialPosition(int value)
        {
            return _position % value == 0 || _position.ToString().Contains(value.ToString());
        }
    }
}