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
using CourseWork.Views;

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public string username;

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow authorization = new MainWindow();
            authorization.Show();
            this.Close();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
            this.Close();
        }

        private void Attendance_Click(object sender, RoutedEventArgs e)
        {
        }
        private void StudentsList_Click(object sender, RoutedEventArgs e)
        {
        }
        private void AttendanceAdd_Click(object sender, RoutedEventArgs e)
        {
        }

        private void AddModule_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ModulesList_Click(object sender, RoutedEventArgs e)
        {
        }

    }
}
