using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace WeWork.MyFirstAddin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class WallInspector : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var doc = commandData.Application.ActiveUIDocument.Document;
            var allWalls = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Walls).OfType<Wall>();
            var dialog = new ReviewWindow(allWalls);
            dialog.ShowDialog();

            return Result.Succeeded;
        }
    }
}
