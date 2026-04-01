using RealTimeWinFormsApp.Interfaces;
using RealTimeWinFormsApp.Models;

namespace RealTimeWinFormsApp.Plugins;

public class ExamplePlugin : IDataViewPlugin
{
    public string PluginName => "Example Counter View";

    public Form CreateView(SharedDataModel dataModel)
    {
        return new FormPluginExample(dataModel);
    }
}
