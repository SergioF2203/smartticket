using System;
using System.Collections.ObjectModel;
using System.Windows;
using Client.AdminService;

namespace Client.Admin
{
    public partial class AdminPanel : Window
    {
	    private DLAdmin _dlAdmin;
		private ObservableCollection<Bus> _buses;

        public AdminPanel()
        {
            InitializeComponent();
			InitFunction();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_dlAdmin.GetBusById(1).Model);
        }

        private void InitFunction()
        {
			_dlAdmin = new DLAdmin();
			_buses = new ObservableCollection<Bus>();
		}

        //private void ShowFunction()
        //{
        //    foreach (var id in _buses)
        //    {
        //        MessageBox.Show(_dlAdmin.GetBusById(Convert.ToInt16(id)).Model);
        //    }
        //}




	}
}
