using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Client.AdminService;

namespace Client.Admin
{
    public partial class AdminPanel : Window, INotifyPropertyChanged
    {
        DLAdmin dl = new DLAdmin();
        private ObservableCollection<Bus> _mBus;
        public event PropertyChangedEventHandler PropertyChanged;


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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MyBuses();
        }

        private void InitFunction()
        {    
            mBus = dl.GetAllBuses();
        }
    }
}
