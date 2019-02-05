using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Client.AdminService;

namespace Client.Admin
{
	public partial class AdminPanel : Window, INotifyPropertyChanged
	{

		private readonly DLAdmin _dlAdmin;
		private ObservableCollection<Bus> _buses;
		public event PropertyChangedEventHandler PropertyChanged;


		public AdminPanel()
		{
			InitializeComponent();
			_dlAdmin = new DLAdmin();
			_buses = new ObservableCollection<Bus>();
			DataContext = this;
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

		private void RefreshButton_Click(object sender, RoutedEventArgs e)
		{
			Buses = _dlAdmin.GetAllBuses();
		}



		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
