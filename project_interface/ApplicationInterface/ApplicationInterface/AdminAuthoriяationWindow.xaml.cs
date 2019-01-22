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

namespace ApplicationInterface
{
    /// <summary>
    /// Логика взаимодействия для AdminAuthoriяationWindow.xaml
    /// </summary>
    public partial class AdminAuthoriяationWindow : Window
    {
        public AdminAuthoriяationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "admin" && PasswordTextBox.Text == "admin")
            {
                AdminWindow aw = new AdminWindow();
                aw.Show();
                this.Close();
            }
        }
    }
}
