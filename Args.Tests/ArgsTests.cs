using Xunit;

namespace ArgsLib.Tests
{
    public class ArgsTests
    {
        [Fact]
        public void shold_get_normal_command()
        {
            var args = new Args("s:string,i:int,b:bool", "-s /usr/local -i 100 -b");
            Assert.Equal(100,args.GetValue("i"));
            Assert.Equal(true, args.GetValue("b"));
            Assert.Equal("/usr/local", args.GetValue("s"));
        }
    }

    
}