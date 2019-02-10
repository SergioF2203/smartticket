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

namespace Client.Admin.Trips
{
    /// <summary>
    /// Логика взаимодействия для AddTrips.xaml
    /// </summary>
    public partial class AddTrips : Window, INotifyPropertyChanged
    {
        DLAdmin dl = new DLAdmin();
        private ObservableCollection<Direction>  _Directions;
        private ObservableCollection<Bus> _buses;
        public event PropertyChangedEventHandler PropertyChanged;

        public AddTrips()
        {
            InitializeComponent();
            DataContext = this;
            _Directions = new ObservableCollection<Direction>();
            _buses = new ObservableCollection<Bus>();
            Buses = dl.GetAllBuses();

            foreach (var dir in  dl.GetAllDirections())
            {
                if(dir.IsActive == true)
                {
                    _Directions.Add(dir);
                }
            }
            
        }

        public ObservableCollection<Direction> Directions
        {
            get { return _Directions; }    
            set
            {
                _Directions = value;
                OnPropertyChanged(nameof(Directions));
            }
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Trip _trip = new Trip { DirectionId = _SelectedItem.Id, BusId = SelectedItem.Id };
            //dl.
        }
        private Bus selectedItem;
        public Bus SelectedItem
        {
            get { return selectedItem; }
            set
            {

                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        private Direction _selectedItem;
        public Direction _SelectedItem
        {
            get { return _selectedItem; }
            set
            {

                _selectedItem = value;
                OnPropertyChanged(nameof(_SelectedItem));
            }
        }
    }
}
