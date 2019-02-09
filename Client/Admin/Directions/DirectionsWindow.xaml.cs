using Client.AdminService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client.Admin.Directions
{
    /// <summary>
    /// Логика взаимодействия для DirectionsWindow.xaml
    /// </summary>
    public partial class DirectionsWindow : Window
    {
        DLAdmin dl = new DLAdmin();
        public DirectionsWindow()
        {
            InitializeComponent();
            fill();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            var dir_new = (Direction)ap.DirectionListView.SelectedItem;
            dir_new.IsActive = IsEnabledCheckbox.IsChecked.Value ;
            var Newlist = new List<Direction>();
            foreach(var d in ap.Directions)
            {
                Newlist.Add(d);
            }
            dl.SaveDirections(Newlist);
            this.Close();
        }
        private void fill()
        {
            
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            if(ap.DirectionListView.SelectedItems.Count > 0)
            {
                var dir = (Direction)ap.DirectionListView.SelectedItem;
                if (dir.IsActive)
                {
                    IsEnableTextBlock.Text = "ENABLED";
                    IsEnabledCheckbox.IsChecked = true;
                }
                else
                {
                    IsEnableTextBlock.Text = "DISABLED";
                    IsEnabledCheckbox.IsChecked = false;
                }
                CityTextBlock.Text = dir.City;

            }
        }
    }
}
