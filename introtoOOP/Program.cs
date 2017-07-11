using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introtoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //when we initalize a new object , it is called INSTANTIATING(creating a new instance)
            //an object needs to be instantiated before it can be used
            //all objects of a specific type are created from the same template - Class
            //all objects from a class will have same number and type of states, BUT ...
            //each instance can have its own unique values.

            //the format we use to instantiate an object looks like this:
            //ClassName objectName = new className();
            Cat firstCat = new Cat();

            firstCat.Name = "Mittens";
            //Console.WriteLine(firstCat.Age);

            Cat secondCat = new Cat("OZ", 3, " orange and white");
            secondCat.Name = "OZZY";
            Console.WriteLine(secondCat.Name);
            Console.WriteLine(secondCat.Age);
            secondCat.Eat();
            //to create a new object. we use a special method called a CONSTRUCTOR

            //thinking aboout objects in real life, create (either hand write or type)
            //three examples of objects. your objects should have five states(characteristics)
            //and five behaviors
        }
       
    }
}
