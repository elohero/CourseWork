﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls.Primitives;
using CourseWork.Views;

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Login_Clicked(object sender, RoutedEventArgs e)
        {
            if (DatabaseManager.IsCorrectLogin(UsernameTextBox.Text, PasswordTextBox.Password))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You entered wrong username or password");
            }
        }

        private void Register_Clicked(object sender, RoutedEventArgs e)
        {
            DatabaseManager.CreateUser(UsernameTextBox.Text, PasswordTextBox.Password, NameTextBox.Text, SurnameTextBox.Text);

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= UsernameTextBox_GotFocus;
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox ptb = (PasswordBox)sender;
            ptb.Password = string.Empty;
            ptb.GotFocus -= PasswordTextBox_GotFocus;
        }

        private void NameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= NameTextBox_GotFocus;
        }

        private void SurnameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= SurnameTextBox_GotFocus;
        }
    }
}
