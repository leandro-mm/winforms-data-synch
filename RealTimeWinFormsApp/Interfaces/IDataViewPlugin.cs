using RealTimeWinFormsApp.Models;

namespace RealTimeWinFormsApp.Interfaces;

public interface IDataViewPlugin
{
    string PluginName { get; }
    Form CreateView(SharedDataModel dataModel);
}
