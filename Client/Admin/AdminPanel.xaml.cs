using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            this.Close();
        }

        private void InitFunction()
        {
			_dlAdmin = new DLAdmin();
			_buses = new ObservableCollection<Bus>();
		}




	}
}
