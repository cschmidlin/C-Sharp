using System;
namespace VarmintHunt {
    class Varmint : ICritter {
        private int hunger;

        public Varmint(int value) {
            Hunger = value;
            Console.WriteLine("Another varmint has hatched");
        }
        private int Hunger {
            get { return hunger; }
            set { hunger = value; }
        }
        public void Howdy(){
            Console.WriteLine("Hi! How are you?!");
        }
    }
}