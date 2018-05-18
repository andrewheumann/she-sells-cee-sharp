using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_demo
{
    public class ViewModel
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public Florp Florp { get; set; }

        public ObservableCollection<Entry> Entries { get; set; }
    }
}
