using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для AddNewTask.xaml
    /// </summary>
    public partial class AddNewTask : Window
    {
        private bool editFlag = false;
        private MyTask oldTask;

        public AddNewTask()
        {
            editFlag = false;
            InitializeComponent();
        }

        public AddNewTask(MyTask myTask)
        {
            InitializeComponent();
            if (myTask != null)
            {
                oldTask = new MyTask(myTask);
                Title.Text = myTask.Title;
                Category.Text = myTask.Category;
                Priority.Text = myTask.Priority;
                Status.Text = myTask.Status;
                Description.Text = myTask.Description;
                editFlag = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Title.Text == "" || Category.Text == "" || Priority.Text == "" || Status.Text == "")
            {
                MessageBox.Show("Input ERROR");
                return;
            }
            if (!editFlag)
            {
                (new DataBase()).AddMyTask((new MyTask(Title.Text, Category.Text, Priority.Text, DateTime.Now, Status.Text, Description.Text)));
            }
            else
            {
                (new DataBase()).EditMyTask(oldTask, (new MyTask(Title.Text, Category.Text, Priority.Text, DateTime.Now, Status.Text, Description.Text)));
            }
            this.Close();
        }
    }
}
