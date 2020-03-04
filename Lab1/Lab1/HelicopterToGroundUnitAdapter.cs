using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HelicopterToGroundUnitAdapter: IMilitaryUnit,IMovableToward
    {
        Helicopter helicopter;
        public HelicopterToGroundUnitAdapter(Helicopter hel)
        {
            helicopter = hel;
        }

        public override void GetDescription()
        {
            throw new NotImplementedException();
        }

        public void MoveToward()
        {
            helicopter.MoveUpAndToward();
        }
    }
}
