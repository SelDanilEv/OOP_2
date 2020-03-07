using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.setStrategy(new RunToWalkStrategy());
            IObservable FireObserv = new FireGunObserver();
            for (int i = 0; i < 5; i++)
                FireObserv.AddObserver(new Invoker());

            Receiver receiver = new FireGunReceiver(FireObserv);

            Command Jump = new JumpCommand(receiver);
            Command Run = new RunCommand(receiver);
            Command Walk = new WalkCommand(receiver);
            Command Sit = new SitCommand(receiver);
            Command FireGun = new FireGunCommand(receiver);
            Command StayGun = new StayCommand(receiver);

            Reestablish reestablisher = new Reestablish();

            bool flag = true;
            while (flag)
            {
                var x = Console.ReadKey();
                Console.Write('\r');
                switch (x.Key)
                {
                    case ConsoleKey.J:
                        invoker.SetCommand(Jump);
                        invoker.GoJump();
                        break;
                    case ConsoleKey.R:
                        invoker.SetCommand(Run);
                        invoker.GoRun();
                        break;
                    case ConsoleKey.W:
                        invoker.SetCommand(Walk);
                        invoker.GoWalk();
                        break;
                    case ConsoleKey.S:
                        invoker.SetCommand(Sit);
                        invoker.GoSit();
                        break;
                    case ConsoleKey.F:
                        invoker.SetCommand(FireGun);
                        invoker.GoFire();
                        break;
                    case ConsoleKey.T:
                        invoker.SetCommand(StayGun);
                        invoker.GoStay();
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("Save state");
                        reestablisher.History = invoker.CreateMemento();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("Reestablish state");
                        invoker.SetMemento(reestablisher.History);
                        invoker.Run();
                        break;
                    case ConsoleKey.E:
                        Console.Write("Exit");
                        flag = false;
                        continue;
                    default:
                        continue;
                }
            }
        }
    }
}
