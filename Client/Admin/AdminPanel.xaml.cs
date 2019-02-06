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

		private  DLAdmin _dlAdmin;
		private ObservableCollection<Bus> _buses;
		public event PropertyChangedEventHandler PropertyChanged;
        //private Bus selectedItem = null;
        //public Bus SelectedItem
        //{
        //    get => selectedItem;
        //    set
        //    {
        //        //if (selectedItem == value) return;
        //        selectedItem = value;
        //        OnPropertyChanged(nameof(SelectedItem));
        //    }
        //}


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

        //private void deleteBus()
        //{
        //    Buses.Remove(selectedItem);
        //}

        //public void addBus(Bus bus)
        //{
        //    Buses.Add(bus);
        //}

        private void BuListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            BusCrud bc = new BusCrud();
            bc.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Bus b = new Bus { RegNumber = "АР5065CP", Capacity = 40, Model = "Ikarus" };
            //_dlAdmin.AddBus(b);
            //_dlAdmin.SaveBus(b);


        }
    }

}
