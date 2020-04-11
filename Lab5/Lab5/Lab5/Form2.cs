using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab5
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class MyAtr : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputValue = value as string;
            var isValid = true;

            if (!string.IsNullOrEmpty(inputValue))
            {
                isValid = inputValue != "GG";
            }
            return isValid;
        }
    }


    public partial class Form2 : Form
    {
        public Form2(List<Discipline> disciplines)
        {
            InitializeComponent();
            list = new List<Discipline>(disciplines);
        }

        [MyAtr(ErrorMessage = "Lector not GG")]
        public string Lector { get; set; }
        [Range(1, 2, ErrorMessage = "Semester error")]
        public int semester { get; set; }
        int course;
        Regex regex = new Regex("[0-9]{1}");


        public List<Discipline> list;
        public List<Discipline> reslist1;
        public List<Discipline> reslist2;

        private void Search_button_Click(object sender, EventArgs e)
        {
            reslist1 = list;
            bool valid = true;
            reslist2 = new List<Discipline>();
            Lector = "";
            semester = 0;
            course = 0;
            if (!this.textBoxLector.Text.Equals(String.Empty))
            {
                Lector = textBoxLector.Text;
                var rc = reslist1.FindAll(x => x.DLector.FullName == Lector);
                reslist1 = new List<Discipline>();
                foreach (var x in rc)
                {
                    reslist1.Add(x);
                }
            }
            if (!this.textBox1.Text.Equals(String.Empty))
            {
                if (Regex.IsMatch((textBox1.Text),@"^[1-2].$"))
                    valid = false;
                semester = int.Parse(textBox1.Text);
                var rc = reslist1.FindAll(x => x.semester == semester);
                reslist1 = new List<Discipline>();
                foreach (var x in rc)
                {
                    reslist1.Add(x);
                }
            }
            if (!this.Text_box_course.Text.Equals(String.Empty))
            {
                course = int.Parse(Text_box_course.Text);
                var rc = reslist1.FindAll(x => x.course == course);
                reslist1 = new List<Discipline>();
                foreach (var x in rc)
                {
                    reslist1.Add(x);
                }
            }
            this.richTextBoxResult.Text = String.Empty;


            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }


            if (!valid)
                this.richTextBoxResult.Text = "Regular expression error";
            else
            {
                if (reslist1.Count != 0)
                {
                    foreach (var x in reslist1)
                    {
                        this.richTextBoxResult.Text += x.ToString() + '\n';
                    }
                }
                else
                {
                    this.richTextBoxResult.Text = "no matches found";
                }
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            this.textBoxLector.Text = String.Empty;
            this.textBox1.Text = String.Empty;
            this.Text_box_course.Text = String.Empty;
            this.richTextBoxResult.Text = String.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }
    }
}
