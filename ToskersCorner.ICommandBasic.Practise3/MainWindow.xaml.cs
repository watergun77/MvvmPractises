﻿using System.Windows;
using ToskersCorner.ICommandBasic.Practise3.ViewModels;

namespace ToskersCorner.ICommandBasic.Practise3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MessageViewModel();
        }
    }
}
