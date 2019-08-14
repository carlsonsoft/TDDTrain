using System;
using System.Reflection.Metadata.Ecma335;
using GameNumber;
using Xunit;

namespace GameNumberTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        public void At_NormalPosition_Return_Position(int position,string excepted)
        {
            Assert.Equal(excepted,FizzBuzz.At(position));
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(12, "Fizz")]
        public void At_PositionBeDivided3_Return_Fizz(int position, string excepted)
        {
            Assert.Equal(excepted, FizzBuzz.At(position));
        }
        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void At_PositionBeDivided5_Return_Buzz(int position, string excepted)
        {
            Assert.Equal(excepted, FizzBuzz.At(position));
        }
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void At_PositionBeDivided3And5_Return_FizzBuzz(int position, string excepted)
        {
            Assert.Equal(excepted, FizzBuzz.At(position));
        }
        [Theory]
        [InlineData(13, "Fizz")]
        [InlineData(23, "Fizz")]
        public void At_PositionBeContain3_Return_Fizz(int position, string excepted)
        {
            Assert.Equal(excepted, FizzBuzz.At(position));
        }
        [Theory]
        [InlineData(59, "Buzz")]
        [InlineData(58, "Buzz")]
        public void At_PositionBeContain5_Return_Buzz(int position, string excepted)
        {
            Assert.Equal(excepted, FizzBuzz.At(position));
        }
        [Theory]
        [InlineData(53, "FizzBuzz")]
        [InlineData(54, "FizzBuzz")]
        public void Test(int position, string excepted)
        {
            Assert.Equal(excepted, FizzBuzz.At(position));
        }
    }


}
