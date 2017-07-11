﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introtoOOP
{
    class Superhero
    {
        // 4 fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;

        // 5 properties
        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }

        public string Name
        {
            get { return this.name; }
        }
        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Power
        {
            get { return this.power; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        //more than 1 constructor you must use a default constructor 
        // 3 constructors
        public Superhero()
        {
            //this is my default constructor
        }

        public Superhero(string name)
        {
            this.name = name;
            this.strengthLevel = 100;
        }

        public Superhero(string costume,string name, int strengthLevel, string power, bool hasCape )
        {
            this.costume = costume;
            this.name = name;
            this.strengthLevel = strengthLevel;
            this.power = power;
            this.hasCape = hasCape;
        }
        // 2 methods
    }
}
