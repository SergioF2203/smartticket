using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Client.Admin.Customers;
using Client.Admin.Directions;
using Client.Admin.Orders;
using Client.AdminService;

namespace Client.Admin
{
	public partial class AdminPanel : Window, INotifyPropertyChanged
	{

		private DLAdmin _dlAdmin;
		private ObservableCollection<Bus> _buses;
        private ObservableCollection<Customer> _customers;
        private ObservableCollection<Order> _orders;
        private ObservableCollection<Direction> _directions;
		public event PropertyChangedEventHandler PropertyChanged;
        private Bus selectedItem;
        public Bus SelectedItem
        {
	        get { return selectedItem; }
			//get => selectedItem;
            set
            {

                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }


        public AdminPanel()
		{
			InitializeComponent();
			_dlAdmin = new DLAdmin();
			_buses = new ObservableCollection<Bus>();
            _customers = new ObservableCollection<Customer>();
            _orders = new ObservableCollection<Order>();
            _directions = new ObservableCollection<Direction>();
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
        public ObservableCollection<Customer> Customers
        {
			get { return _customers;}
			//get => _customers;
            set
            {
                _customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }
        public ObservableCollection<Order> Orders
        {
			get { return _orders;}
			//get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged(nameof(Orders));
            }
        }
        public ObservableCollection<Direction> Directions
        {
			get { return _directions;}
			//get => _directions;
            set
            {
                _directions = value;
                OnPropertyChanged(nameof(Directions));
            }
        }

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
		private void RefreshButton_Click(object sender, RoutedEventArgs e)
		{
			Buses = _dlAdmin.GetAllBuses();
            Customers = _dlAdmin.GetAllCustomers();
            Directions = _dlAdmin.GetAllDirections();
            Orders = _dlAdmin.GetAllOrders();
		}
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
        private void BuListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            BusCrud bc = new BusCrud();
            bc.Show();
        }

        private void CustomersListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CrudCustomerWindow ccw = new CrudCustomerWindow();
            ccw.Show();
        }

        private void OrderListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CrudOrderWindow cow = new CrudOrderWindow();
            cow.Show();
        }

        private void DirectionListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DirectionsWindow dw = new DirectionsWindow();
            dw.Show();
        }
    }

}
