using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var actual = ConsoleApplication.Program.Add(2, 3);

            Assert.True(actual == 5);
        }
    }
}