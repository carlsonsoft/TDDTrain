using Xunit;

namespace ArgsLib.Tests
{
    public class PraserTests
    {

        [Theory]
        [InlineData("s", "/usr/local")]
        [InlineData("b", "true")]
        [InlineData("i", "100")]
        public void shold_parse_normal_command(string name, string excepted)
        {
            Schemas schemas = new Schemas("s:string,i:int,b:bool");
            Praser praser = new Praser("-s /usr/local -b true -i 100");
            Assert.Equal(excepted, praser.GetValue(name));
        }

        [Theory]
        [InlineData("s", "/usr/local")]
        [InlineData("b", "true")]
        [InlineData("i", "100")]
        public void shold_parse_default_command(string name, string excepted)
        {
            Schemas schemas = new Schemas("s:string,i:int,b:bool");
            Praser praser = new Praser("-s /usr/local -b -i 100");
            Assert.Equal(excepted, praser.GetValue(name));
        }

        [Theory]
        [InlineData("s", "/usr/local")]
        [InlineData("b", "true")]
        [InlineData("i", "-100")]
        public void shold_parse_navg_command(string name, string excepted)
        {
            Schemas schemas = new Schemas("s:string,i:int,b:bool");
            Praser praser = new Praser("-s /usr/local -i -100 -b");
            Assert.Equal(excepted, praser.GetValue(name));
        }

    }
}