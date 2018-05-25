using System.Collections.Generic;
using Autodesk.Revit.DB;

namespace WeWork.MyFirstAddin
{
    public class WallProxy
    {
        public int ElementId { get; set; }
        public string WallType { get; set; }
        public double Width { get; set; }
        public string Function { get; set; }
        public string Kind { get; set; }
        public string FamilyName { get; set; }
        public Dictionary<string, string> Parameters { get; set; }

        public static WallProxy FromRevitWall(Wall wall)
        {
            var proxy = new WallProxy
            {
                ElementId = wall.Id.IntegerValue,
                WallType = wall.WallType.Name,
                Width = wall.Width,
                Function = wall.WallType.Function.ToString(),
                Kind = wall.WallType.Kind.ToString(),
                FamilyName = wall.WallType.FamilyName,
                Parameters = new Dictionary<string, string>()
            };

            foreach (var param in wall.GetOrderedParameters())
            {
                if (!proxy.Parameters.ContainsKey(param.Definition.Name))
                {
                    proxy.Parameters[param.Definition.Name] = param.AsValueString();
                }
            }

            return proxy;
        }
    }
}