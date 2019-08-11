using Xunit;

namespace GameNumber.Tests
{
    public class SayTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(11)]
        public void At_NormalPosition_ReturnRawPosition(int position)
        {
            Assert.Equal(position.ToString(), CreateGameNumberSay(position));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(13)]
        public void At_PositionDivided3OrContain3_ReturnFizz(int position)
        {
            Assert.Equal("Fizz", CreateGameNumberSay(position));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(52)]
        [InlineData(56)]
        public void At_PositionDivided5OrContain5_ReturnBuzz(int position)
        {
            Assert.Equal("Buzz", CreateGameNumberSay(position));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        public void At_PositionDivided5AndDivided3_ReturnFizzBuzz(int position)
        {
            Assert.Equal("FizzBuzz", CreateGameNumberSay(position));
        }

        private string CreateGameNumberSay(int position)
        {
            return new GameNumber(position).Say();
        }
    }
}
