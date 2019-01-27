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

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для AdminAuthorizationWindow.xaml
    /// </summary>
    public partial class AdminAuthorizationWindow : Window
    {
        public AdminAuthorizationWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTextbox.Text == "admin" && PasswordTextBox.Password.ToString() == "admin") 
            {
                //открываем окно админской панели
                AdminPanelWindow apw = new AdminPanelWindow();
                apw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("проверте правильность ввода", "логин или пароль не верен");
            }
        }
    }
}
