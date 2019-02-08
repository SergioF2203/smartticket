using Client.AdminService;
using System;
using System.Threading;
using System.Windows;

namespace Client.Admin
{
    /// <summary>
    /// Логика взаимодействия для EditBusWindow.xaml
    /// </summary>
    public partial class EditBusWindow : Window
    {
        private DLAdmin dl = new DLAdmin();
        public EditBusWindow()
        {
            InitializeComponent();
            fill();  
        }

        public void fill()
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            var b_old = (Bus)ap.BusListView.SelectedItem;
            regNUmberTextBlock.Text = b_old.RegNumber;
            ModelTextBlock.Text = b_old.Model;
            CapacityTextBlock.Text =(b_old.Capacity).ToString();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            var b = (Bus)ap.BusListView.SelectedItem;
            b.RegNumber = RegNumberTextBox.Text;
            b.Model = ModelTextBox.Text;
            b.Capacity = Convert.ToInt16(CapacityTextBox.Text);
            dl.SaveBus(b);
            this.Close();
        }
    }
}
