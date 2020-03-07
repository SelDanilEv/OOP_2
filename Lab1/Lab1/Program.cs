using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Leader leader1 = Leader.getleader("Boris");
            Leader leader2 = Leader.getleader("Danil");

            leader1.PrintLeaderName();
            leader2.PrintLeaderName();

            IMilitaryFactory tankFactory = new TankMilitatyFactory();
            IMilitaryFactory soldierFactory = new SoldierMilitatyFactory();


            List<IMilitaryUnit> soldiers = soldierFactory.makeMilitaryUnits(10);
            List<IMilitaryUnit> tanks = tankFactory.makeMilitaryUnits(15);

            List<IMilitaryUnit> AllMilitaryUnits = soldiers;

            Helicopter firstHelicopter = new Helicopter();

            IMovableToward AdaptedHelicopter = new HelicopterToGroundUnitAdapter(firstHelicopter);

            foreach (IMilitaryUnit unit in tanks)
            {
                AllMilitaryUnits.Add(unit);
            }

            Tank tankMain = new TankBuilder().SetColor("green").SetName("Main").SetSize(15).build();
            Tank tankLittle = new TankBuilder().SetName("Little").build();
            Tank tankWhite = new TankBuilder().SetColor("White").build();

            AllMilitaryUnits.Add(tankMain);
            AllMilitaryUnits.Add(tankLittle);
            AllMilitaryUnits.Add(tankWhite);

            AllMilitaryUnits.Add((IMilitaryUnit)AdaptedHelicopter);

            ITankPrototype clonedTank = tankMain.Clone();

            Tank Cltank = (Tank)clonedTank;

            Console.WriteLine(clonedTank.GetInfo());
            Console.WriteLine(Cltank.ToString());

            Soldier soldierForDecorate = new Soldier();

            soldierForDecorate = new SolderDecoratorGranad(soldierForDecorate);
            AllMilitaryUnits.Add(soldierForDecorate);
            soldierForDecorate = new SolderDecoratorKnife(soldierForDecorate);
            AllMilitaryUnits.Add(soldierForDecorate);
            soldierForDecorate = new SolderDecoratorGun(soldierForDecorate);
            AllMilitaryUnits.Add(soldierForDecorate);

            foreach (IMilitaryUnit unit in AllMilitaryUnits)
            {
                //unit.getDescription();
                //leader1.SendToAttack(unit);
                ((IMovableToward)unit).MoveToward();
                //Console.WriteLine(unit.ToString());
            }

            Console.ReadKey();

            //--------------------------------------------------------------


            Component fileSystem = new Directory("Файловая система");
            // определяем новый диск
            Component diskC = new Directory("Диск С");
            // новые файлы
            Component pngFile = new File("12345.png", "три");
            Component docxFile = new File("Document.docx", "size");
            // добавляем файлы на диск С
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // добавляем диск С в файловую систему
            fileSystem.Add(diskC);
            // выводим все данные
            fileSystem.Print();
            Console.WriteLine();
            // удаляем с диска С файл
            diskC.Remove(pngFile);
            // создаем новую папку
            Component docsFolder = new Directory("Мои Документы");
            // добавляем в нее файлы
            Component txtFile = new File("readme.txt", "Please read me");
            Component csFile = new File("Program.cs", "I am class");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);


            fileSystem.Print();
            Console.Read();


            Component FindComponent = fileSystem.StartFind("readme.txt");
            if (FindComponent != null)
            {
                Console.WriteLine("Finding readme.txt");
                FindComponent.Print();
            }
            Console.ReadKey();

            //---------------------------------------------------

        }
    }

}
