using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;

namespace WeWork.MyFirstAddin
{
    public class App : IExternalApplication
    {
        public App()
        {

        }
        public Result OnStartup(UIControlledApplication application)
        {
            var rp = AppHelpers.AddRibbonPanel(application, "WeWork", "She Sells");
            AppHelpers.CreateButton("Hello World", "WeWork.MyFirstAddin.MyFirstCommand", "Click this for a fun surprise", rp, "icon.png");
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
