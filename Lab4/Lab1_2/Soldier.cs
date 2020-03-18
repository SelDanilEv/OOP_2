using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public class Container
    {
         public List<Soldier> list = new List<Soldier>();

        public void Add(Soldier soldier)
        {
            list.Add(soldier);
        }

        public void Remove(Soldier soldier)
        {
            List<Soldier> rcList = new List<Soldier>(list);
            foreach (Soldier soldierr in list)
            {
                if (soldier.name == soldierr.name)
                    rcList.Remove(soldierr);
            }
            list = rcList;
        }

        public override string ToString()
        {
            string output = "";

            foreach(Soldier soldier in list)
            {
                output += soldier.ToString();
            }
            return output;
        }
    }
    public class Soldier
    {
        private int number;
        private static int counter = 0;
        string weapon;
        public string name;

        public void GetDescription()
        {
            Console.WriteLine("I am soldier " + number);
        }

        public override string ToString()
        {
            string output ="";
            if (name!=null&&name!="")
                output += "My name is " + name+". ";
            output += "I am soldier " + number;
            if (weapon != null)
                output += " with " + weapon+"\n\n";
            return output;
        }

        public Soldier()
        {
            number = ++counter;
        }

        public Soldier(string Name, string Weapon) : this()
        {
            this.name = Name;
            this.weapon = Weapon;
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
