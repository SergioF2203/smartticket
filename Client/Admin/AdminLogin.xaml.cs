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

namespace Client.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTextBox.Text == "admin" && PasswordTextBox.Password.ToString() == "admin")
            {
                Admin.AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login or password isn't correct!\nTry again!","Error");
            }
        }
    }
}
