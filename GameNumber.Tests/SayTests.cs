using System;
using Xunit;
using  GameNumber;
namespace GameNumber.Tests
{
    public class SayTests
    {

        [Fact]
        public void Should_Say_1_when_Is_1()
        {
            var gameNumber = new GameNumber(1);
            Assert.Equal("1", gameNumber.Say());
        }

        [Fact]
        public void Should_Say_Fizz_when_Is_Divided_By_3()
        {
            var gameNumber = new GameNumber(3);
            Assert.Equal("Fizz", gameNumber.Say());
        }
        [Fact]
        public void Should_Say_Buz_when_Is_Divided_By_5()
        {
            var gameNumber = new GameNumber(5);
            Assert.Equal("Buzz", gameNumber.Say());
        }
        [Fact]
        public void Should_Say_FuzzBuz_when_Is_Divided_By_15()
        {
            var gameNumber = new GameNumber(15);
            Assert.Equal("FizzBuzz", gameNumber.Say());
        }

        
    }
}
