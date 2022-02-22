using System;

namespace AbstractExample.Models
{
    public class Bear : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"Says ROAR");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZ");
        }

        public void Hibernate()
        {
            Console.WriteLine("The bear is hibernating");
        }
    }
}