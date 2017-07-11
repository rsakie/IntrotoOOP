using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introtoOOP
{
    class Cat
    {

        //inside of our class, we create the blueprint for our objects.
        //classes are templates in OOP that we use to creats objects
        //they should all be named in Pascal case.

        //in OOP, there are two types of states:
        //fields- variables that belong to a class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;


        //properties- a sort of mix between a field and a method that allows controlled access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //we also have behaviors.
        //methods- repeatable/reusable sections of code - actions
        //construstors- specialized methods that are used when instantiating an object
        //   - allow us to control the state of an object upon creation
        //   - allow us to preform any actions the object might nedds upon creation.
        //   - always share the same name of the class

        public Cat()
        {
            //this is an example of a default constructor. a default constructor takes
            //no arguements/parameters.
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
             if (isHungry)
            {
            isHungry = false;
            }
            Console.WriteLine("is the cat hungry? " + isHungry);
        }
    }
}
