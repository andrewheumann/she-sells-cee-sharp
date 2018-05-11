using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_demo
{
    public static class SampleDataContext
    {
        public static ViewModel Model => new ViewModel()
        {
            Name = "Only for Designtime",
            Value = 35
        };
    }
}
