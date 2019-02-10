using Client.CustomerService;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for SelectTrip.xaml
    /// </summary>
    public partial class SelectTrip : Window, INotifyPropertyChanged
    {
        private DLCustomer _customer;
        //private int _freePlaces;
        private ObservableCollection<Trip> _trips;
        private Trip selectedTrip;
        public SelectTrip()
        {
            InitializeComponent();
            _trips = new ObservableCollection<Trip>();
            DataContext = this;
            _customer = new DLCustomer();

        }
        public ObservableCollection<Trip> Trips
        {
            get { return _trips; }
            set
            {
                _trips = value;
                OnPropertyChanged(nameof(Trips));
            }
        }
        public Trip SelectedTrip
        {
            get { return selectedTrip; }
            set
            {
                selectedTrip = value;
                OnPropertyChanged(nameof(SelectedTrip));
            }
        }

        //public int FreePlaces
        //{
        //    get { return _freePlaces; }
        //    set
        //    {
        //        _freePlaces = value;
        //        OnPropertyChanged(nameof(FreePlaces));
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void DateTrip_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = (DateTime)dateTrip.SelectedDate;
            if (selectedDate != null)
            {
                Trips = _customer.GetTripsByDate(selectedDate);
                int count = 0;
                for (int i = 0; i < Trips.Count; i++)
                {

                }
            }
        }

        private void NextSelectTrip_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(selectedTrip.Bus.Id.ToString());
            switch (selectedTrip.Bus.Capacity)
            {
                case 47:
                    BusShema47 busShema47 = new BusShema47(selectedTrip);
                    busShema47.Show();
                    break;
            }
        }

        private void PrevSelectTrip_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
