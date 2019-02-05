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
            mBus = new ObservableCollection<Bus>();

            var buses = dl.GetAllBuses();
            foreach(var b in buses)
            {
                mBus.Add(new Bus { Id = b.Id, Model = b.Model, RegNumber = b.RegNumber, Capacity = b.Capacity });
            }
        }
    }
}
