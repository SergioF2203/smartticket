using Client.AdminService;
using System;
using System.Windows;

namespace Client.Admin.Orders
{
    /// <summary>
    /// Логика взаимодействия для EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        DLAdmin dl = new DLAdmin();
        public EditOrderWindow()
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
            var or_new = (Order)ap.OrderListView.SelectedItem;
            or_new.CustomerId = Convert.ToInt16(CustomeridTextBox.Text);
            or_new.TripId = Convert.ToInt16(TripIdTextBox.Text);
            or_new.PlaceNumber = Convert.ToInt16(PlaceNumberTextBox.Text);
            dl.SaveOrder(or_new);
            this.Close();
        }
        private void fill()
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            var or_old = (Order)ap.OrderListView.SelectedItem;
            CustomeridTextBlock.Text = or_old.CustomerId.ToString();
            TripIdTextBlock.Text = or_old.TripId.ToString();
            PlaceNumberTextBlock.Text = or_old.PlaceNumber.ToString();
        }
    }
}
