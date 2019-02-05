using System;
using System.Collections.ObjectModel;
using System.Windows;
using Client.AdminService;

namespace Client.Admin
{
    public partial class AdminPanel : Window
    {
        public ObservableCollection<Bus> mBus;



        public AdminPanel()
        {
            InitializeComponent();  
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MyBuses();
        }
    }
}
