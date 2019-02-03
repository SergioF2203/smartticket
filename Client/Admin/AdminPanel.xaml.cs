using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using BusStationService.Lib;

namespace Client.Admin
{
    public partial class AdminPanel : Window
    {
        private ObservableCollection<Bus> _buses;
        private DL _dl;
        public ObservableCollection<Bus> Buses
        {
            get { return _buses; }
            set { _buses = value; }
        }


        public AdminPanel()
        {
            InitializeComponent();
            _buses = new ObservableCollection<Bus>();
            _dl = new DL();
            InitFunction();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void InitFunction()
        {
            //var buses = _dl.
        }




    }
}
