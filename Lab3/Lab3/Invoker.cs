using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Invoker : StrategyHelpClass, IObserver
    {
        Command command;

        public Invoker()
        {
            State = new StayState();
        }

        public void setStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
            command = memento.command;
        }

        public Memento CreateMemento()
        {
            return new Memento(this);
        }

        public IInvokerState State { get; set; }

        public override Strategy strategy { get; set; }

        public void SetCommand(Command c)
        {
            command = c;
        }
        public Command GetCommand()
        {
            return command;
        }

        public void GoRun()
        {
            State.Run(this);
        }

        public void GoWalk()
        {
            State.Walk(this);
        }

        public void GoJump()
        {
            State.Jump(this);
        }

        public void GoStay()
        {
            State.Stay(this);
        }

        public void GoSit()
        {
            State.Sit(this);
        }

        public void GoFire()
        {
            State.FireGun(this);
        }

        public void Run()
        {
            command.Execute();
        }

        public void Update()
        {
            Console.WriteLine("I hear shots ");
        }

        //public void Cancel()
        //{
        //    command.Undo();
        //}
    }

    class RunState : IInvokerState
    {
        public void Execute(Invoker invoker)
        {
            invoker.Run();
            if (invoker.strategy != null)
                invoker.strategy.Algorithm();
        }

        public void Fail()
        {
            Console.WriteLine("You need to walk before run");
        }

        public void FireGun(Invoker invoker)
        {
            Fail();
        }

        public void Jump(Invoker invoker)
        {
            Fail();
        }

        public void Run(Invoker invoker)
        {
            Console.WriteLine("He is already running");
        }

        public void Sit(Invoker invoker)
        {
            Fail();
        }

        public void Stay(Invoker invoker)
        {
            Fail();
        }

        public void Walk(Invoker invoker)
        {
            invoker.State = new WalkState();
            Execute(invoker);
        }
    }

    class JumpState : IInvokerState
    {
        public void Execute(Invoker invoker)
        {
            invoker.Run();
        }

        public void Fail()
        {
            Console.WriteLine("You need to walk before jump");
        }

        public void FireGun(Invoker invoker)
        {
            Fail();
        }

        public void Jump(Invoker invoker)
        {
            Console.WriteLine("He is already jumping");
        }

        public void Run(Invoker invoker)
        {
            Fail();
        }

        public void Sit(Invoker invoker)
        {
            Fail();
        }

        public void Stay(Invoker invoker)
        {
            invoker.State = new StayState();
            Execute(invoker);
        }

        public void Walk(Invoker invoker)
        {
            invoker.State = new WalkState();
            Execute(invoker);
        }
    }

    class WalkState : IInvokerState
    {
        public void Execute(Invoker invoker)
        {
            invoker.Run();
        }

        public void Fail()
        {
            Console.WriteLine("You need to jump,stay ot run before walk");
        }

        public void FireGun(Invoker invoker)
        {
            Fail();
        }

        public void Jump(Invoker invoker)
        {
            invoker.State = new JumpState();
            Execute(invoker);
        }

        public void Run(Invoker invoker)
        {
            invoker.State = new RunState();
            Execute(invoker);
        }

        public void Sit(Invoker invoker)
        {
            Fail();
        }

        public void Stay(Invoker invoker)
        {
            invoker.State = new StayState();
            Execute(invoker);
        }

        public void Walk(Invoker invoker)
        {
            Console.WriteLine("He is already walking");
        }
    }

    class StayState : IInvokerState
    {
        public void Execute(Invoker invoker)
        {
            invoker.Run();
        }

        public void Fail()
        {
            Console.WriteLine("You need to sit or walk before stay");
        }

        public void FireGun(Invoker invoker)
        {
            Fail();
        }

        public void Jump(Invoker invoker)
        {
            invoker.State = new JumpState();
            Execute(invoker);
        }

        public void Run(Invoker invoker)
        {
            Fail();
        }

        public void Sit(Invoker invoker)
        {
            invoker.State = new SitState();
            Execute(invoker);
        }

        public void Stay(Invoker invoker)
        {
            Console.WriteLine("He is already staying");
        }

        public void Walk(Invoker invoker)
        {
            invoker.State = new WalkState();
            Execute(invoker);
        }
    }

    class SitState : IInvokerState
    {
        public void Execute(Invoker invoker)
        {
            invoker.Run();
        }

        public void Fail()
        {
            Console.WriteLine("You need to fire or stay before sit");
        }

        public void FireGun(Invoker invoker)
        {
            invoker.State = new FireGunState();
            Execute(invoker);
        }

        public void Jump(Invoker invoker)
        {
            Fail();
        }

        public void Run(Invoker invoker)
        {
            Fail();
        }

        public void Sit(Invoker invoker)
        {
            Console.WriteLine("He is already siting");
        }

        public void Stay(Invoker invoker)
        {
            invoker.State = new StayState();
            Execute(invoker);
        }

        public void Walk(Invoker invoker)
        {
            Fail();
        }
    }

    class FireGunState : IInvokerState
    {
        public void Execute(Invoker invoker)
        {
            invoker.Run();
        }

        public void Fail()
        {
            Console.WriteLine("You need to sit down before fire");
        }

        public void FireGun(Invoker invoker)
        {
            Console.WriteLine("He is already firing");
        }

        public void Jump(Invoker invoker)
        {
            Fail();
        }

        public void Run(Invoker invoker)
        {
            Fail();
        }

        public void Sit(Invoker invoker)
        {
            invoker.State = new SitState();
            Execute(invoker);
        }

        public void Stay(Invoker invoker)
        {
            Fail();
        }

        public void Walk(Invoker invoker)
        {
            Fail();
        }
    }

    class Receiver
    {
        protected IObservable observer;
        public Receiver(IObservable obs)
        {
            observer = obs;
        }

        public virtual void Jump()
        { Console.WriteLine("Jump"); }

        public virtual void Run()
        { Console.WriteLine("Run"); }

        public virtual void Sit()
        { Console.WriteLine("Sit"); }

        public virtual void Stay()
        { Console.WriteLine("Stay"); }

        public virtual void Walk()
        { Console.WriteLine("Walk"); }

        public virtual void FireGun()
        { Console.WriteLine("FireGun"); }
    }

    class FireGunReceiver : Receiver
    {
        public FireGunReceiver(IObservable obs) : base(obs) { }

        public override void FireGun()
        {
            base.FireGun();
            observer.NotifyObservers();
        }
    }

    interface IInvokerState
    {
        void Run(Invoker invoker);
        void Jump(Invoker invoker);
        void Walk(Invoker invoker);
        void Stay(Invoker invoker);
        void Sit(Invoker invoker);
        void FireGun(Invoker invoker);
        void Fail();
        void Execute(Invoker invoker);
    }

    public abstract class StrategyHelpClass
    {
        public abstract Strategy strategy { get; set; }
    }
}
