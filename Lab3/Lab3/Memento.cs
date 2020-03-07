using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Memento
    {
        public IInvokerState State { get; set; }
        public Command command { get; set; }
        public Memento(Invoker invoker)
        {
            this.State = invoker.State;
            this.command = invoker.GetCommand();
        }
    }

    class Reestablish
    {
        public Memento History { get; set; }
    }


}
