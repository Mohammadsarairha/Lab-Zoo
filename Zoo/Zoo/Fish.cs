using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Fish : Animal ,IAnimal
    {
        public void FishGills()
        {
            Console.WriteLine("All Fishs have Fish Gills");
        }

        void IAnimal.Growth()
        {
            Console.WriteLine("all fish grow");
        }
    }
    public interface IFish
    {
        void Swim();
        void ColdBlooded();
    }
}
