using Client.AdminService;
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

namespace Client.Admin.Orders
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        DLAdmin dl = new DLAdmin();
        public AddOrderWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomeridTextBox.Text != "" && TripIdTextBox.Text != "" && PlaceNumberTextBox.Text != "")
            {
                var o = new Order { CustomerId = Convert.ToInt16(CustomeridTextBox.Text), TripId = Convert.ToInt16(TripIdTextBox.Text), PlaceNumber = Convert.ToInt16(PlaceNumberTextBox.Text)  };
                dl.AddOrder(o);
                this.Close();
            }
        }
    }
}
