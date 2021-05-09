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
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
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
            DatabaseManager.CreateStudent(AddressTextBox.Text, PhoneTextBox.Text, ParrentFullNameTextBox.Text, IsLivingInObchagaTextBox.Text);

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void ParrentFullNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= ParrentFullNameTextBox_GotFocus;
        }

        private void IsLivingInObchagaTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox ptb = (TextBox)sender;
            ptb.Text = string.Empty;
            ptb.GotFocus -= IsLivingInObchagaTextBox_GotFocus;
        }

        private void AddressTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= AddressTextBox_GotFocus;
        }

        private void PhoneTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox utb = (TextBox)sender;
            utb.Text = string.Empty;
            utb.GotFocus -= PhoneTextBox_GotFocus;
        }
    }
}
