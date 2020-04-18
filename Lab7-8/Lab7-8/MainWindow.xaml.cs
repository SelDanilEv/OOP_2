using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7_8
{
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            ViewModel.ViewModel viewModel = new ViewModel.ViewModel(Tasks);
            DataContext = viewModel;
            //DataContext = this;
            ClickEvent = EventManager.RegisterRoutedEvent(
                "Control_MouseDown",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(ButtonBase));
        }

        private static int _style = 0;

        private string ExampleString = "SomeStr";
        public string JustValue
        {
            get { return ExampleString; }
            set
            {
                ExampleString = value;
                NotifyPropertyChanged();
            }
        }

        private void Set_Language(string Language)
        {
            string strLanguage = "Lab7_8.Languages." + Language;
            ResourceManager LocRM = new ResourceManager(strLanguage, Assembly.GetExecutingAssembly());
            Edit_Button.Content = LocRM.GetString("Edit");
            Add_Button.Content = LocRM.GetString("Add");
            HeaderText.Text = LocRM.GetString("Header");
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (((Slider)sender).Value)
            {
                case 1:
                    Set_Language("English");
                    break;
                case 0:
                    Set_Language("Russian");
                    break;
            }
        }

        private void ChangeStyle(object sender, RoutedEventArgs e)
        {
            Uri uri;
            switch (_style)
            {
                case 0:
                    uri = new Uri($"Style/BlueStyle.xaml", UriKind.Relative);
                    _style++;
                    break;
                case 1:
                    uri = new Uri($"Style/GreenStyle.xaml", UriKind.Relative);
                    _style = 0;
                    break;
                default:
                    uri = new Uri($"Style/BlueStyle.xaml", UriKind.Relative);
                    break;
            }
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }


        public RoutedEvent ClickEvent;
        public event RoutedEventHandler Click
        {
            add
            {
                base.AddHandler(ButtonBase.ClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(ButtonBase.ClickEvent, value);
            }
        }

        public void DoEvent(object sender, MouseButtonEventArgs e)
        {
            ; MessageBox.Show(ClickEvent.RoutingStrategy.ToString());
            Control_MouseDown(sender, e);
        }

        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = "sender: " + sender.ToString() + "\n";
            textBlock1.Text += "source: " + e.Source.ToString() + "\n\n";
        }



        public static RoutedCommand GreetUserCommand = new RoutedUICommand("Howdy!", "GreetUser", typeof(MainWindow));

        public void GreetUser_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public static void GreetUser_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Howdy howdy I'm a cowboy");
        }

        private void txtSomeText_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }
    }
}
