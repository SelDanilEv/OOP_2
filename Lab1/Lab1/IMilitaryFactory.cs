using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IMilitaryFactory
    {
        IMilitaryUnit makeMilitaryUnit();
        List<IMilitaryUnit> makeMilitaryUnits(int count);
    }


    class TankMilitatyFactory : IMilitaryFactory
    {
        public IMilitaryUnit makeMilitaryUnit()
        {
            return new Tank();
        }

        public List<IMilitaryUnit> makeMilitaryUnits(int count)
        {
            List<IMilitaryUnit> rc = new List<IMilitaryUnit>();
            if (count > 0)
            {
                for (int i = 0; i < count; i++)

                    rc.Add(new Tank());
            }
            return rc;
        }
    }

    class SoldierMilitatyFactory : IMilitaryFactory
    {
        public IMilitaryUnit makeMilitaryUnit()
        {
            return new Soldier();
        }

        public List<IMilitaryUnit> makeMilitaryUnits(int count)
        {
            List<IMilitaryUnit> rc = new List<IMilitaryUnit>();
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                    rc.Add(new Soldier());
            }
            return rc;
        }
    }
}
