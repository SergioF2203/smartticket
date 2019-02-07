using Client.AdminService;
using System.Windows;

namespace Client.Admin.Customers
{
    /// <summary>
    /// Логика взаимодействия для AddCustomerWindow.xaml
    /// </summary>
    public partial class CrudCustomerWindow : Window
    {
        DLAdmin dl = new DLAdmin();
        public CrudCustomerWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow acw = new AddCustomerWindow();
            acw.Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            if(ap.CustomersListView.SelectedItems.Count > 0)
            {
                var c = (Customer)ap.CustomersListView.SelectedItem;
                dl.DeleteCustomer(c.Id);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditCustomerWindow ecw = new EditCustomerWindow();
            ecw.Show();
        }
    }
}
