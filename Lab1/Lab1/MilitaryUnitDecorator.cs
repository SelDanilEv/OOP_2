using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SolderDecoratorGun : Soldier
    {
        public SolderDecoratorGun(Soldier unit) : base(unit, "Gun")
        {
        }

        public void GetDescription()
        {
            Console.WriteLine(base.ToString());
        }
    }

    class SolderDecoratorKnife : Soldier
    {
        public SolderDecoratorKnife(Soldier unit) : base(unit, "Knife")
        {
        }

        public void GetDescription()
        {
            Console.WriteLine(base.ToString());
        }
    }

    class SolderDecoratorGranad : Soldier
    {
        public SolderDecoratorGranad(Soldier unit) : base(unit, "Granad")
        {

        }

        public void GetDescription()
        {
            Console.WriteLine(base.ToString());
        }
    }
}
