using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Leader
    {
        private static Leader leader;

        private Leader()
        {

        }

        public string Name { get; set; }

        public static void Say()
        {
            Console.WriteLine("I am leader");
        }

        public static Leader getleader(string name)
        {
            if (leader == null)
            {
                leader = new Leader();
                leader.Name = name;
            }

            return leader;
        }

        public void SendToAttack(IMilitaryUnit militaryUnit)
        {
            Console.WriteLine("Attack ");
            militaryUnit.GetDescription();
        }

        public void PrintLeaderName()
        {
            Console.WriteLine(leader.Name);
        }
    }
}
