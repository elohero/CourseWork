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

namespace CourseWork.Views
{
    /// <summary>
    /// Логика взаимодействия для AddVisit.xaml
    /// </summary>
    public partial class AddVisit : Window
    {
        public AddVisit()
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

        private void Register_Clicked(object sender, RoutedEventArgs e)
        {
            DatabaseManager.CreateVisit(StudentNameTextBox.Text, LessonTextBox.Text, DateTextBox.Text);

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void StudentNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= StudentNameTextBox_GotFocus;
        }

        private void LessonTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= LessonTextBox_GotFocus;
        }

        private void DateTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox ptb = (TextBox)sender;
            ptb.Text = string.Empty;
            ptb.GotFocus -= DateTextBox_GotFocus;
        }
    }
}
