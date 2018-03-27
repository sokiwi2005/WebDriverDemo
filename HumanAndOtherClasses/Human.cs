using System;
namespace loops
{
    public class Human
    {
       /* // The following are the properties of the class. 
       Instead of hardcoding the properties, we will make these
        properties as parameters for using this class - by creating a parameterised
        constructor for this class. 
        Remember a class can have multiple parameterised constructors so that the class 
        can be instantiated using a variety of parameters 

        We use create variable names for the properties here - it's good practice to 
        write `_propertyName` in the properties.


        If we directly wanted to hardcode the property values, we could say

        int _age = 28; string _name = "Sonal"*/

        int _age;
        int _height;
        string _name;
        int _weight;
        public Animal _animal;
        public int _niceness;

        //constructor always has the same name as the class but it is a method
        //it never has a return Type because the return will be obbject itself
        // the following is a default constructor
        //public Human()
        //{
        //    _age = 10;
        //    _height = 164;
        //    _name = "Ram";
        //    _weight = 52;
        //    _animal = new Animal(1,"cat","meow",5);
                
        //}
        //Parametrised constructor:
        public Human(int age, int height, string name, int weight, Animal animal, int niceness)
		{
            _age = age;
            _height = height;
            _name = name;
            _weight = weight;
            _animal = animal;
            _niceness = niceness;
            if (_niceness >= 5)
            {
                _animal.giveCuddles();
            }
            else if (_niceness <= 3)
            {
                _animal.scoldIt();
            }
		}
        public Human(string name)
        {
            _name = name;
        }

        public Human (Animal animal)
        {
            _animal = animal;
        }
        //(public and private are used for limiting the scope of the method - private makes it available only to that class - because other modules / classes dont need to access this method.)
        // Class is a template
        // You create an object of a class - means you create a new object using the class template.
        // 



        public void birthdayCheck(string day)
        {
            if (day == "my birthday")
            {
                _age++;
                Console.WriteLine("Happy Birthday! You turned "+ _age + " years old today");
            }
            else {
                Console.WriteLine("Just another day!");
            }
        }

        public void setName(string name)
        {
            if (name == "Sonal")
            {
                _name = name;
            }
            else
                Console.WriteLine("INTRUDER!!!");
        }

        public void pleaseGiveMeSecret(int age)
        {
            if (age > 13)
            {
                tellSecret();
            }
            else
                Console.WriteLine("Sorry PG-13 only");
        }

        private void tellSecret()
        {
            Console.WriteLine("My secret is I'm crazy abt rahul");
        }

        public string getName()
        {
            return _name;
        }

    }
}
