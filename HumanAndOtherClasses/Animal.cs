using System;
namespace loops
{
    public class Animal
    {
        int _age;
        string _species;
        string _sound;
        int _happinesLevel;

        public Animal(int age, string species, string sound, int happinesLevel)
        {
            _age = age;
            _species = species;
            _sound = sound;
            _happinesLevel = happinesLevel;
        }

        public void giveCuddles()
        {
            _happinesLevel++;
        }
        public void scoldIt()
        {
            _happinesLevel = 0;
        }

        public void whereWillYouPoop()
        {
            if (_happinesLevel == 0)
            {
                Console.WriteLine("In your lap");
            }
            else 
            {
                Console.WriteLine("In the litter box");
            }
                
        }
    }
}
