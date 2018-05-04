using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_app
{
    public class ViewModel
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }

    public static class ViewModelSampleDataContext
    {
        public static ViewModel Model => new ViewModel
        {
            Name = "HELLO!",
            Value = 12
        };
    }
}
