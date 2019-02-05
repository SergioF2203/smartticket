using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class AdminPanel : Window, INotifyPropertyChanged
    {

		//private ObservableCollection<Bus> _buses;

		//      public AdminPanel()
		//      {
		//          InitializeComponent();
		//	InitFunction();
		//      }

		//      private void ExitButton_Click(object sender, RoutedEventArgs e)
		//      {
		//          this.Close();
		//      }

		//      private void InitFunction()
		//      {
		//	_dlAdmin = new DLAdmin();
		//	_buses = new ObservableCollection<Bus>();
		//}

		private DLAdmin _dlAdmin;
	    private ObservableCollection<Bus> _buses; 
		public event PropertyChangedEventHandler PropertyChanged;

	    public AdminPanel()
	    {
			InitializeComponent();
		    DataContext = this;
			_buses = new ObservableCollection<Bus>();
	    }

	    public ObservableCollection<Bus> Buses
	    {
		    get { return _buses; }
		    set
		    {
			    _buses = value;
			    OnPropertyChanged(nameof(Buses));
		    }
	    }

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}







		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
