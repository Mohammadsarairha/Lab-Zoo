using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public abstract string name { get; set; }
        public abstract string gender { get; set; }
        public abstract double weight { get; set; }

        public virtual string Sound()
        {
            return "All animals have sound";
        }

        public virtual string Eat()
        {
            return "All animals can eat";
        }

        public virtual string Sleep()
        {
            return "All animals need to sleep";
        }

        public virtual bool See()
        {
            return true;
        }
        public abstract string Growth();
    }

    interface IOrganism
    {
        string Respiration();
        string Movement();
    }

    interface IAnimal
    {
        string Multicellular();
        string Reproduce();
    }

    interface IBird
    {
        string Fly();
        string Vertebrates();
        string WarmBlooded();
        string Wings();
        string Wings(string feathers);
    }

    interface IFish
    {
        string Swim();
        string ColdBlooded();
    }

    public abstract class Mammal : Animal
    {
        public void Skin()
        {
            Console.WriteLine("All Mammal have Skin");
        }
    }

    public abstract class Bird : Animal
    {
        public void Feathers()
        {
            Console.WriteLine("All Birds have feathers");
        }
    }

    public abstract class Fish : Animal
    {
        public void FishGills()
        {
            Console.WriteLine("All Fishs have Fish Gills");
        }
    }

    public class Lion : Mammal , IOrganism,IAnimal
    {
        public override string name{get;set;}
        public override string gender { get; set; }

        public override double weight { get; set; }

        public string Respiration()
        {
            return "Respiration";
        }

        public string Movement()
        {
            return "Run";
        }

        public string Multicellular()
        {
            return "Multicellular";
        }

        public string Reproduce()
        {
            return "Reproduce";
        }

        public override string Sound()
        {
            return "Roars";
        }

        public override string Sleep()
        {
            return "Sleep 12 hours";
        }

        public override string Eat()
        {
            return "Meat";
        }

        public override bool See()
        {
            return true;
        }

        public override string Growth()
        {
            return "growth";
        }
    }


    public class Dog : Mammal ,IOrganism,IAnimal
    {
       public override string name{get;set;}
        public override string gender {get;set;}

        public override double weight{get; set;}

        public string Respiration()
        {
            return "Respiration";
        }

        public string Movement()
        {
            return "Run";
        }

        public string Multicellular()
        {
            return "Multicellular";
        }

        public string Reproduce()
        {
            return "Reproduce";
        }


        public override string Sound()
        {
            return "Bark";
        }

        public override string Sleep()
        {
            return "Sleep 15 hours";
        }

        public override string Eat()
        {
            return "Meat";
        }

        public override bool See()
        {
            return true;
        }
        public override string Growth()
        {
            return "growth";
        }

    }

    public class Shark : Fish ,IOrganism,IAnimal ,IFish
    {
        public override string name{get;set;}
        public override string gender { get; set; }

        public override double weight { get; set; }

        public string Respiration()
        {
            return "Respiration";
        }

        public string Movement()
        {
            return "Run";
        }

        public string Multicellular()
        {
            return "Multicellular";
        }

        public string Reproduce()
        {
            return "Reproduce";
        }

        public string Swim()
        {
            return "swim";
        }

        public string ColdBlooded()
        {
            return "ColdBlooded";
        }

        public override string Sound()
        {
            return "No sound";
        }

        public override string Sleep()
        {
            return "Sleep 6 hours";
        }

        public override string Eat()
        {
            return "Fishes";
        }

        public override bool See()
        {
            return true;
        }
        public override string Growth()
        {
            return "growth";
        }

    }

    public class Falcon : Bird ,IOrganism ,IAnimal ,IBird
    {

        public override string name{get;set;}
        public override string gender { get; set; }

        public override double weight { get; set; }

        public string Respiration()
        {
            return "Respiration";
        }

        public string Movement()
        {
            return "fly";
        }

        public string Multicellular()
        {
            return "Multicellular";
        }

        public string Reproduce()
        {
            return "Reproduce";
        }

        public string Fly()
        {
            return "fly";
        }

        public string Vertebrates()
        {
            return "Vertebrates";
        }

        public string WarmBlooded()
        {
            return "WarmBlooded";
        }

        public string Wings()
        {
            return "Wings";
        }
        public string Wings(string feathers)
        {
            return "Wings";
        }

        public override string Sound()
        {
            return "Rasping";
        }

        public override string Sleep()
        {
            return "Sleep 10 hours";
        }

        public override string Eat()
        {
            return "Birds";
        }

        public override bool See()
        {
            return true;
        }
        public override string Growth()
        {
            return "growth";
        }
    }

    public class Sheep : Mammal ,IOrganism,IAnimal
    {
        public override string name{get;set;}

        public override string gender { get; set; }

        public override double weight { get; set; }

        public string Respiration()
        {
            return "Respiration";
        }

        public string Movement()
        {
            return "Run";
        }

        public string Multicellular()
        {
            return "Multicellular";
        }

        public string Reproduce()
        {
            return "Reproduce";
        }


        public override string Sound()
        {
            return "Maa";
        }

        public override string Sleep()
        {
            return "Sleep 8 hours";
        }

        public override string Eat()
        {
            return "plant";
        }

        public override bool See()
        {
            return true;
        }
        public override string Growth()
        {
            return "growth";
        }
    }

}
