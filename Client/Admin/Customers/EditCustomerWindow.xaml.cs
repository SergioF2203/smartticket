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

namespace Client.Admin.Customers
{
    /// <summary>
    /// Логика взаимодействия для EditCustomerWindow.xaml
    /// </summary>
    public partial class EditCustomerWindow : Window
    {
        DLAdmin dl = new DLAdmin();
        public EditCustomerWindow()
        {
            InitializeComponent();
            fill();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            var c_new = (Customer)ap.CustomersListView.SelectedItem;
            //b.RegNumber = RegNumberTextBox.Text;
            //b.Model = ModelTextBox.Text;
            //b.Capacity = Convert.ToInt16(CapacityTextBox.Text);
            //dl.SaveBus(b);
            c_new.Name = NameTextBox.Text;
            c_new.Phone = PhoneTextBox.Text;
            c_new.Email = EmailTextBox.Text;
            dl.SaveCustomer(c_new);

            this.Close();

        }
        private void fill()
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            var c_old = (Customer)ap.CustomersListView.SelectedItem;
            NameTextBlock.Text = c_old.Name;
            PhoneTextBlock.Text = c_old.Phone;
            EmailTextBlcok.Text = c_old.Email;
        }
    }
}
