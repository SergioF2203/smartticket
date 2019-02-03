using System;
using System.Collections.ObjectModel;
using System.Windows;
using Client.AdminService;

namespace Client.Admin
{
    public partial class AdminPanel : Window
    {
        public DLAdmin _dlAdmin;
		public ObservableCollection<Bus> _buses;

        

        public AdminPanel()
        {
            InitializeComponent();
            MainGrid.ItemsSource = _buses;
			
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            InitFunction();
            //this.Close();
        }

        private void InitFunction()
        {
            _buses = _dlAdmin.GetAllBuses();
		}






	}
}
