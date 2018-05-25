using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.MyFirstAddin
{
    public class ViewModel
    {
        public ObservableCollection<WallProxy> Walls { get; set; }
        public WallProxy SelectedWall { get; set; }
    }
}
