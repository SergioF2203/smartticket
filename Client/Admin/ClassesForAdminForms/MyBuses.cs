using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Client.AdminService;

namespace Client.Admin
{
    class MyBuses
    {
        DLAdmin dl = new DLAdmin();

        private ObservableCollection<Bus> _mBus;
        public ObservableCollection<Bus> mBus
        {
            get { return _mBus; }
            set { _mBus = value; }
        }

        public MyBuses()
        {
            mBus = dl.GetAllBuses();
        }
    }
}
