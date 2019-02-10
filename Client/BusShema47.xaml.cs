using Client.CustomerService;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for BusShema47.xaml
    /// </summary>
    public partial class BusShema47 : Window, INotifyPropertyChanged
    {
        private Trip currentTrip;
        public BusShema47(Trip selectedTrip)
        {
            InitializeComponent();
            CurrentTrip = selectedTrip;
            OccupiedPlaces();

        }
        public Trip CurrentTrip
        {
            get { return currentTrip; }
            set
            {
                currentTrip = value;
                OnPropertyChanged(nameof(CurrentTrip));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void OccupiedPlaces()
        {
            DLCustomer dLCustomer = new DLCustomer();
            List<int> places = dLCustomer.GetOccupiedPlaces(CurrentTrip.Id);
            List<string> places_s = new List<string>();
            foreach(var pl in places)
            {
                string temp = pl.ToString();
                places_s.Add(temp);
            }
            foreach (var chbx in busCanvas.Children)
            {
                if (chbx is CheckBox)
                {
                    CheckBox checkBox = chbx as CheckBox;
                    foreach (var plc in places_s)
                    {
                        if (checkBox.Name == "place" + plc)
                        {
                            checkBox.IsEnabled = false;
                        }
                    }
                }
            }
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
