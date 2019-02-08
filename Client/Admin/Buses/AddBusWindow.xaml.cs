using Client.AdminService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для AddBusWindow.xaml
    /// </summary>
    public partial class AddBusWindow : Window
    {
        private DLAdmin dl = new DLAdmin();

        public AddBusWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RegNumberTextBox.Text != "" && ModelTextBox.Text != "" && CapacityTextBox.Text != "")
            {
                var b = new Bus { RegNumber = RegNumberTextBox.Text, Model = ModelTextBox.Text, Capacity = Convert.ToInt16(CapacityTextBox.Text) };
                dl.AddBus(b);
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
