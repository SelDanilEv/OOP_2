using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Tank : IMilitaryUnit, ITankPrototype,IMovableToward
    {
        private int number;
        private static int counter = 0;

        public int size = 5;
        public string color = "black";
        public string name;

        public string GetName()
        {
            if (name != null)
                return name;
            return "Tank " + number;
        }

        public void GetDescription()
        {
            Console.WriteLine("I am tank " + number);
        }

        public Tank()
        {
            number = ++counter;
        }

        public Tank(TankBuilder tank) : this()
        {
            this.color = tank.color;
            if (tank.name != null)
                this.name = tank.name;
            this.size = tank.size;
        }

        public override string ToString()
        {
            return "\n\nI am tank " + number +
                "\nMy size " + size +
                "\nMy name " + GetName() +
                "\nMy color " + color + '\n';
        }

        public ITankPrototype Clone()
        {
            return new Tank(this.name, this.size, this.color);
        }

        public string GetInfo()
        {
            return ToString();
        }

        public void MoveToward()
        {
            Console.WriteLine("I am tank " + number + " and i go toward");
        }

        public Tank(string name, int size, string color) : this()
        {
            this.name = name;
            this.size = size;
            this.color = color;
        }
    }

    class TankBuilder
    {
        public int size = 5;
        public string color = "black";
        public string name;

        public TankBuilder SetSize(int size)
        {
            this.size = size;
            return this;
        }
        public TankBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }
        public TankBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public Tank build()
        {
            return new Tank(this);
        }
    }
}
