using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Bird : Animal ,IAnimal 
    {
        public void Feathers()
        {
            Console.WriteLine("All Birds have feathers");
        }

        void IAnimal.Growth()
        {
            Console.WriteLine("all bird grow");
        }
    }

    public interface IBird
    {
        string Fly();
        void Wings();
        void Wings(string feathers);
    }
}
