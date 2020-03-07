using System;
using System.Collections.Generic;
using System.Text;



namespace Lab3
{
    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    class JumpCommand : Command
    {
        Receiver receiver;
        public JumpCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Jump();
        }

        public override void Undo()
        {
            receiver.Walk();
        }
    }

    class StayCommand : Command
    {
        Receiver receiver;
        public StayCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Stay();
        }

        public override void Undo()
        {
            receiver.Walk();
        }
    }

    class RunCommand : Command
    {
        Receiver receiver;
        public RunCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Run();
        }

        public override void Undo()
        {
            receiver.Walk();
        }
    }

    class WalkCommand : Command
    {
        Receiver receiver;
        public WalkCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Walk();
        }

        public override void Undo()
        {
            receiver.Stay();
        }
    }

    class SitCommand : Command
    {
        Receiver receiver;
        public SitCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Sit();
        }

        public override void Undo()
        {
            receiver.Stay();
        }
    }

    class FireGunCommand : Command
    {
        Receiver receiver;
        public FireGunCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.FireGun();
        }

        public override void Undo()
        {
            receiver.Sit();
        }
    }

}

//// конкретная команда
//class ConcreteCommand : Command
//{
//    Receiver receiver;
//    public ConcreteCommand(Receiver r)
//    {
//        receiver = r;
//    }
//    public override void Execute()
//    {
//        receiver.Operation();
//    }

//    public override void Undo()
//    { }
//}

//// получатель команды
//class Receiver
//{
//    public void Operation()
//    { }
//}
// инициатор команды
//class Invoker
//{
//    Command command;
//    public void SetCommand(Command c)
//    {
//        command = c;
//    }
//    public void Run()
//    {
//        command.Execute();
//    }
//    public void Cancel()
//    {
//        command.Undo();
//    }
//}
//}
