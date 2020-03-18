using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        bool validate;

        public Form1()
        {
            InitializeComponent();
            ViewDisciplines();
            //textBoxTitle.Validating += textBoxTitle_Validating;
            //groupBox1Course.Validating += groupBox1Course_Validating;
            //comboBox1.Validating += comboBox1_Validating;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxAllowLabs_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLabs.Value = 0;
            numericUpDownLabs.Enabled = checkBoxAllowLabs.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPulpit.Text = textBoxFullName.Text = "";
            textBoxPulpit.Enabled = textBoxFullName.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate = true;
            richTextBoxLog.Text = "";
            int course=0;

            var tryFindCourse = groupBox1Course.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            if (tryFindCourse == null)
            {
                validate = false;
                richTextBoxLog.Text += "No Course\n";
                errorProvider1.SetError(groupBox1Course, "No Course\n");
            }
            else
            {
                course = int.Parse(tryFindCourse.Text);
                errorProvider1.Clear();
            }
            int semester = (int)numericUpDownSemester.Value;
            string specialty= "";

            if (comboBox1.Text == "")
            {
                validate = false;
                richTextBoxLog.Text += "No Specialty\n";
                errorProvider1.SetError(comboBox1, "No Specialty\n");
            }
            else
            {
                specialty = comboBox1.Text;
                errorProvider1.Clear();
            }

            int quanOfLect = (int)numericUpLectures.Value;
            int quanOfLabs = (int)numericUpDownLabs.Value;

            string typeOfControl = comboBoxTypeOfControl.Text;

            string title = textBoxTitle.Text;
            if (textBoxTitle.Text == "")
            {
                validate = false;
                richTextBoxLog.Text += "No Title\n";
                errorProvider1.SetError(textBoxTitle, "No Title\n");
            }
            else
                errorProvider1.Clear();

            if (validate)
            {
                Serializer serializer = new Serializer();
                if (checkBox1.Checked)
                {
                    serializer.WriteFile(new Discipline(title,semester,course,specialty,quanOfLect,quanOfLabs,typeOfControl, new Lector(textBoxPulpit.Text, textBoxFullName.Text)));
                }
                else
                {
                    serializer.WriteFile(new Discipline(title, semester, course, specialty, quanOfLect, quanOfLabs, typeOfControl));
                }
                ViewDisciplines();
                MessageBox.Show("Added on\n "+dateTimePicker1.Value.ToShortDateString());
            }

            //Form form = new Form2();
            //form.ShowDialog();
            //form.Show();
        }

        private void ViewDisciplines()
        {
            Serializer serializer = new Serializer();
            richTextBoxShow.Text = "";
            var list = serializer.ReadFile();
            foreach(Discipline discipline in list)
            {
               richTextBoxShow.Text+= discipline.ToString()+'\n';
            }
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                validate = false;
                richTextBoxLog.Text += "No Title\n";
                errorProvider1.SetError(textBoxTitle, "No Title\n");
            }
            else
                errorProvider1.Clear();
        }

        private void groupBox1Course_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
