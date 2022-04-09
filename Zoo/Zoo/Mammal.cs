using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Mammal : Animal, IAnimal
    {
        void IAnimal.Growth()
        {
            Console.WriteLine("all mammal grow");
        }
    }

    public interface IMammal
    {
        void Skin();
        void Reproduction();
    }
}
