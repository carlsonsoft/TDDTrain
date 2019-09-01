using Xunit;

namespace ArgsLib.Tests
{
    public class SchemaTests
    {
        [InlineData("b","true",true)]
        [InlineData("b", "false", false)]
        [InlineData("b", "", false)]
        [Theory]
        public void should_accept_bool(string name, string value,bool excepted)
        {
            Schemas schemas = new Schemas("b:bool");
            Assert.Equal(excepted, schemas.GetValue(name, value));
        }

        [InlineData("i", "1", 1)]
        [InlineData("i", "", 0)]
        [InlineData("i", null, 0)]
        [InlineData("i", "-1", -1)]
        [Theory]
        public void should_accept_int(string name, string value, int excepted)
        {
            Schemas schemas = new Schemas("i:int");
            Assert.Equal(excepted, schemas.GetValue(name, value));
        }
        [InlineData("s", "1", "1")]
        [InlineData("s", "", "")]
        [InlineData("s", null, "")]
        [InlineData("s", "-1", "-1")]
        [Theory]
        public void should_accept_str(string name, string value, string excepted)
        {
            Schemas schemas = new Schemas("s:string");
            Assert.Equal(excepted, schemas.GetValue(name, value));
        }
        
    }

    
}
