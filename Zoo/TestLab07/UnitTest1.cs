using System;
using Xunit;
using Zoo;

namespace TestLab07
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Sheep sheep = new Sheep();
            Assert.Equal("Respiration", sheep.Respiration());
        }

        [Fact]
        public void Test2()
        {
            Dog dog = new Dog();
            dog.gender = "mael";
            Assert.Equal("mael", dog.gender);
        }

        [Fact]
        public void Test3()
        {
            Falcon falcon = new Falcon();
            Assert.Equal(falcon.Wings(), falcon.Wings("feathers"));
        }
    }
}
