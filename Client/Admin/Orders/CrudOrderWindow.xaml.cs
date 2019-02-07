using Client.AdminService;
using System.Windows;

namespace Client.Admin.Orders
{
    /// <summary>
    /// Логика взаимодействия для CrudOrderWindow.xaml
    /// </summary>
    public partial class CrudOrderWindow : Window
    {
        DLAdmin dl = new DLAdmin();
        public CrudOrderWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            if (ap.OrderListView.SelectedItems.Count > 0)
            {
                var o = (Order)ap.OrderListView.SelectedItem;
                dl.DeleteOrder(o.Id);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow aow = new AddOrderWindow();
            aow.Show();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditOrderWindow eow = new EditOrderWindow();
            eow.Show();
        }
    }
}
