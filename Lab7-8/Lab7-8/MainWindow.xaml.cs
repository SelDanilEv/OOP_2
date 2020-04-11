using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7_8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel.ViewModel viewModel = new ViewModel.ViewModel(Tasks);
            DataContext = viewModel;
        }

        private static int _style = 0;


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
    }
}
