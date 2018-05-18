using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_demo
{
    public static class SampleDataContext
    {
        public static ViewModel Model => new ViewModel
        {
            Name = "Only for Designtime",
            Value = 35,
            Entries = new ObservableCollection<Entry>
            {
                new Entry {Name = "John", Value=20},
                new Entry {Name = "Dave", Value=78},
                new Entry {Name = "James", Value=45}
            },
            Florp = new Florp { Flizoop = "Blap"}
        };
    }
}
