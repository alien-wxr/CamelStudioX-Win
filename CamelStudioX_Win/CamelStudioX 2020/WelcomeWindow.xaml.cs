﻿using MahApps.Metro.Controls;
using System.Windows;

namespace CamelStudioX_2020
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : MetroWindow
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void newProject_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
