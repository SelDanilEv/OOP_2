using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public interface Strategy
    {
        void Algorithm();
    }

    public class RunToWalkStrategy : Strategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Loud breathing");
        }
    }
}
