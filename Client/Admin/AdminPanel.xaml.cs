using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
<<<<<<< HEAD
=======
using System.Runtime.CompilerServices;
>>>>>>> upstream/master
using System.Windows;
using Client.AdminService;

namespace Client.Admin
{
<<<<<<< HEAD
    public partial class AdminPanel : Window, INotifyPropertyChanged
    {
        DLAdmin dl = new DLAdmin();
        private ObservableCollection<Bus> _mBus;
        public event PropertyChangedEventHandler PropertyChanged;
=======
	public partial class AdminPanel : Window, INotifyPropertyChanged
	{
>>>>>>> upstream/master

		//private ObservableCollection<Bus> _buses;

<<<<<<< HEAD
        public ObservableCollection<Bus> mBus
        {
            get { return _mBus; }
            set
            {
                _mBus = value;
            }
        }


        public AdminPanel()
        {
            InitializeComponent();
            InitFunction();
        }
=======
		//      public AdminPanel()
		//      {
		//          InitializeComponent();
		//	InitFunction();
		//      }

		//      private void ExitButton_Click(object sender, RoutedEventArgs e)
		//      {
		//          this.Close();
		//      }
>>>>>>> upstream/master

		//      private void InitFunction()
		//      {
		//	_dlAdmin = new DLAdmin();
		//	_buses = new ObservableCollection<Bus>();
		//}

		private readonly DLAdmin _dlAdmin;
		private ObservableCollection<Bus> _buses;
		public event PropertyChangedEventHandler PropertyChanged;

<<<<<<< HEAD
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MyBuses();
        }

        private void InitFunction()
        {    
            mBus = dl.GetAllBuses();
        }
    }
=======
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
>>>>>>> upstream/master
}
