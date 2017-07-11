using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introtoOOP
{
    class Dog
    {
        //creat a dog class
        //your dog class should have fields for hair lenght, height, running speed, and weight

        private string hairLength;
        private int height;
        private int speed;
        private double weight;
        private bool crap = true;
        public string HairLength
        {
            get { return this.HairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public int Weight
        {
            get { return this.Weight; }
            set { this.weight = value; }
        }

        //you class should have the following behaviors: run, bark, potty, cuddle
        // you should have atleast one constructor


        //constructor
        public Dog()
        {
            //this is my default constructor

        }
        public Dog(string hairLength, int height, int speed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.speed = speed;
            this.weight = weight;
        }

        public int Run()
        {
            Console.WriteLine("Go doggy go!!");
            Speed -= 1;
            return speed;
        }

        public void Bark()
        {
            Console.WriteLine("Bork bork bork!!");
        }

        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("you dog just made a mess");
            }
            else
            {
                Console.WriteLine("your dog just relieved itself");
            }
        }

        public void Cuddle()
        {
            Console.WriteLine("awww, doggo is so sweet");
        }

    }
}
