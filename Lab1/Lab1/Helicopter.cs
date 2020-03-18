using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Helicopter : IMilitaryUnit,IMovableUpAndToward
    {
        private int number;
        private static int counter = 0;

        public void GetDescription()
        {
            Console.WriteLine("I am helicopter " + number);
        }

        public override string ToString()
        {
            return "I am helicopter " + number;
        }

        public void MoveUpAndToward()
        {
            Console.WriteLine("I am helicopter " + number + " and i go up and toward");
        }

        public Helicopter()
        {
            number = ++counter;
        }
    }
}
