using System;
using Xunit;
using Zoo;
namespace TestZooProject
{
    public class UnitTest1
    {
        //Test animal Eat behavior given to them from a base class Animal class
        [Fact]
        public void Test1()
        {
            Lion lion = new Lion();
            Assert.Equal("Meat",lion.Eat());
        }

        //Test animal Sleep behavior given to them from a base class Animal class
        [Fact]
        public void Test2()
        {
            Lion lion = new Lion();
            Assert.Equal("Sleep 12 hours", lion.Sleep());
        }

        //Test the falcon classes that implement the interface actually implement it from IBird interface
        [Fact]
        public void Test3()
        {
            IBird falcon = new Falcon();
            Assert.Equal("Falcon Fly", falcon.Fly());
        }

        //Test methods have been overridden from base class
        [Fact]
        public void Test4()
        {
            Shark shark = new Shark();
            Assert.Equal("Fishes",shark.Eat());
        }

        //Test sheep class is an Animal
        [Fact]
        public void Test5()
        {
            Animal sheep = new Sheep();
            Assert.Equal("Maa", sheep.Sound());
        }
    }
}
