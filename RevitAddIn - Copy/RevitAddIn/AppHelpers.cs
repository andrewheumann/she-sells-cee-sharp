using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI;
using Autodesk.Windows;
using RibbonPanel = Autodesk.Revit.UI.RibbonPanel;

namespace WeWork.MyFirstAddin
{
    internal class AppHelpers
    {
        internal static RibbonPanel AddRibbonPanel(UIControlledApplication application, string tabName, string panelName)
        {
            // Create a custom ribbon tab
            if (!ComponentManager.Ribbon.Tabs.Any(t => t.Id == tabName)) //if the tab's not already there
            {
                application.CreateRibbonTab(tabName);

            }

            // Add a new ribbon panel
            var ribbonPanel = application.CreateRibbonPanel(tabName, panelName);

            return ribbonPanel;
        }

        public static void CreateButton(string cmdName, string cmdClassName, string toolTip, RibbonPanel ribbonPanel, string iconName)
        {
            // Get dll assembly path
            var thisAssemblyPath = Assembly.GetExecutingAssembly().Location;


            var buttonData = new PushButtonData(
                $"cmd{cmdName.Replace(" ", "")}",
                cmdName,
                thisAssemblyPath,
                cmdClassName);
            var pushButton = ribbonPanel.AddItem(buttonData) as PushButton;
            pushButton.ToolTip = toolTip;
            var image =
                new BitmapImage(new Uri($"pack://application:,,,/WeWork.MyFirstAddin;component/Resources/{iconName}"));
            pushButton.LargeImage = image;

        }
    }
}
