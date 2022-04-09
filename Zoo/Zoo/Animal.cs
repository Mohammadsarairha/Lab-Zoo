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
    }

    interface IAnimal
    {
        void Growth();
    }

    public class Lion : Mammal,IMammal
    {
        public override string name { get; set; }
        public override string gender { get; set; }
        public override double weight { get; set; }


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
        void IMammal.Reproduction()
        {
            Console.WriteLine("Lion reproduction by childbirth");
        }

        void IMammal.Skin()
        {
            Console.WriteLine("Lion have coat");
        }
    }


    public class Dog : Mammal, IMammal
    {
        public override string name { get; set; }
        public override string gender { get; set; }
        public override double weight { get; set; }


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

        void IMammal.Reproduction()
        {
            Console.WriteLine("Dog reproduction by childbirth");
        }

        void IMammal.Skin()
        {
            Console.WriteLine("Dog have coat");
        }
    }

    public class Shark : Fish, IFish
    {
        public override string name { get; set; }
        public override string gender { get; set; }
        public override double weight { get; set; }

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

        void IFish.Swim()
        {
            throw new NotImplementedException();
        }

        void IFish.ColdBlooded()
        {
            Console.WriteLine($"{name} is coldBlooded");
        }
    }

    public class Falcon : Bird, IBird
    {

        public override string name { get; set; }
        public override string gender { get; set; }
        public override double weight { get; set; }

        public Falcon()
        {
            this.name = "Falcon";
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

        string IBird.Fly()
        {
            return $"{name} Fly";
        }

        void IBird.Wings()
        {
            Console.WriteLine("Wings without feathers");
        }

        void IBird.Wings(string feathers)
        {
            Console.WriteLine("Wings with feathers");
        }
    }

    public class Sheep : Mammal ,IMammal
    {
        public override string name { get; set; }

        public override string gender { get; set; }

        public override double weight { get; set; }

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
        
        void IMammal.Reproduction()
        {
            Console.WriteLine("Sheep reproduction by childbirth");
        }

        void IMammal.Skin()
        {
            Console.WriteLine("sheep fur");
        }
    }

}
