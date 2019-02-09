using Client.AdminService;
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
        private ObservableCollection<Trip> _trips;
        private Trip selectedTrip;
        public SelectTrip()
        {
            InitializeComponent();
            _trips = new ObservableCollection<Trip>();

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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void DateTrip_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = dateTrip.SelectedDate;
        }
    }
}
