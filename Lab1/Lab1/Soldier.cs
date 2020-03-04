using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Soldier : IMilitaryUnit, IMovableToward
    {
        private int number;
        private static int counter = 0;
        string weapon;

        public override void GetDescription()
        {
            Console.WriteLine("I am soldier " + number);
        }

        public override string ToString()
        {
            string output;
            output = "I am soldier " + number;
            if (weapon != null)
                output += " with " + weapon;
            return output;
        }

        public Soldier()
        {
            number = ++counter;
        }

        public Soldier(Soldier soldier, string weapon)
        {
            if (soldier.weapon == null)
                soldier.weapon = "";
            this.weapon += soldier.weapon + " with " + weapon;
            this.number = soldier.number;
        }

        public void MoveToward()
        {
            Console.WriteLine("I am soldier " + number + " and i go toward" + weapon);

        }
    }
}
