using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            container = new Container();
        }

        public static Container container;

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string weapon = textBoxWeapon.Text;
            if (name != "" ||name != null)
                container.Add(new Soldier(name, weapon));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            string weapon = textBoxWeapon.Text;

            container.Remove(new Soldier(name, weapon));
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            TextBoxList.Text = container.ToString();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var list = from St in container.list
                       orderby St.name
                       select St;
            string outputtxt = "";
            foreach (Soldier soldier in list)
            {
                outputtxt += soldier.ToString();
            }
            TextBoxList.Text = outputtxt;
        }
    }
}
