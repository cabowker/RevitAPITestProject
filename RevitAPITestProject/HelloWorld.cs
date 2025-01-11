using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPITestProject;

[Transaction(TransactionMode.Manual)]
public class HelloWorld : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        TaskDialog.Show("Hello", "Hello World");
        return Result.Succeeded;
    }
}