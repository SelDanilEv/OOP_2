using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component) { }

        public virtual int GetSize() { return 0; }

        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }

        public virtual Component Find(string name)
        {
            if (name == this.name)
                return this;
            return null;
        }
    }

    class Directory : Component
    {
        private List<Component> components = new List<Component>();

        public Directory(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override int GetSize()
        {
            int size = 0;
            for (int i = 0; i < components.Count; i++)
            {
                size += components[i].GetSize();
            }
            return size;
        }

        static Component rc = null;

        public override Component Find(string name)
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i].Find(name) != null)
                {
                    rc = components[i];
                }
            }

            if (name == this.name)
                rc = this;
            

            return rc;
        }

        public override void Print()
        {
            Console.WriteLine("Узел " + name);
            Console.WriteLine("Размер " + GetSize());
            Console.WriteLine("Подузлы:");
            Console.WriteLine("===============");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
            Console.WriteLine("===============");
        }
    }

    class File : Component
    {
        public File(string name, string text)
                : base(name)
        {
            this.text = text;
        }

        public override void Print()
        {
            Console.WriteLine("Имя файла "+name + "\nРазмер " + text.Length + "\nСодержимое " + text);
        }

        public override int GetSize()
        {
            return text.Length;
        }

        private string text;
    }
}