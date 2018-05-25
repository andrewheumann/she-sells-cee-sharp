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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.DB;

namespace WeWork.MyFirstAddin
{
    /// <summary>
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow 
    {
        public ReviewWindow()
        {
            InitializeComponent();
        }

        public ReviewWindow(IEnumerable<Wall> allWalls)
        {
            DataContext = new ViewModel
            {
                Walls = new ObservableCollection<WallProxy>(allWalls.Select(WallProxy.FromRevitWall))
            };
            InitializeComponent();
        }
    }
}
