using Client.AdminService;
using System.Windows;

namespace Client.Admin.Customers
{
    /// <summary>
    /// Логика взаимодействия для CustomersCrudWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        private DLAdmin dl = new DLAdmin();
        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text != "" && PhoneTextBox.Text != "" && EmailTextBox.Text != "")
            {
                var c = new Customer { Name = NameTextBox.Text, Phone = PhoneTextBox.Text, Email = EmailTextBox.Text };
                dl.AddCustomer(c);
                this.Close();
            }
        }


    }
}
