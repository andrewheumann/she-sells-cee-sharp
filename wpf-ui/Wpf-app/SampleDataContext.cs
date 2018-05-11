using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_app
{
    public static class SampleDataContext
    {
        public static ViewModel Model => new ViewModel
        {
            Name = "World",
            Value = 12,
            Entries = new ObservableCollection<Entry>
            {
                new Entry{Name = "Jim", Value = 20},
                new Entry{Name = "John", Value = 40},
            }
        };
    }
}
