using Lab12_14.Classes;
using Lab12_14.DataBase;
using Lab12_14.ViewModels;
using Lab12_14.Views;
using System;
using System.Data.Entity;
using System.Windows;

namespace Lab12_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new MainView());
            DataContext = new MainViewModel();
        }
    }
}
