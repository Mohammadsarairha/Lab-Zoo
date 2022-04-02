using System;
using Xunit;
using Zoo;
namespace TestLab06
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Lion lion = new Lion();
            Assert.Equal("Sleep 12 hours",lion.Sleep());
        }

        [Fact]
        public void Test2()
        {
            Falcon falcon = new Falcon();
            Assert.Equal("growth", falcon.Growth());
        }
    }
}
