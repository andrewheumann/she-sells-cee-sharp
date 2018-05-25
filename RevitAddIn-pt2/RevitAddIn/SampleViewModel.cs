using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.MyFirstAddin
{
    public class SampleViewModel
    {
        private static ObservableCollection<WallProxy> wallSet => new ObservableCollection<WallProxy>
        {
            new WallProxy
            {
                ElementId = 3432,
                FamilyName = "Wall Fam",
                Function = "Holdin shit up",
                Kind = "Opaque",
                Parameters = new Dictionary<string, string>
                {
                    {"A Parameter", "Its Value"},
                    {"Another Parameter", "Another Value"}
                }
            },
            new WallProxy
            {
                ElementId = 32430,
                FamilyName = "Wall Fam",
                Function = "Holdin shit up",
                Kind = "Opaque",
                Parameters = new Dictionary<string, string>
                {
                    {"A Parameter", "Its Value"},
                    {"Another Parameter", "Another Value"}
                }
            }
        };

        public static ViewModel Model => new ViewModel
        {
            Walls = wallSet,
            SelectedWall = wallSet.First()
        };
    }
}
