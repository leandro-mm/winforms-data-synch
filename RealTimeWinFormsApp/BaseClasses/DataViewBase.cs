using RealTimeWinFormsApp.EventArgs;
using RealTimeWinFormsApp.Models;
namespace RealTimeWinFormsApp.BaseClasses;

public class DataViewBase : Form
{
    public SharedDataModel DataModel { get; private set; }

    // Parameterless constructor for designer support
    public DataViewBase()
    {
        // Designer support only
    }

    protected DataViewBase(SharedDataModel dataModel)
    {
        DataModel = dataModel;
    }

    protected override void OnLoad(System.EventArgs e)
    {
        base.OnLoad(e);

        if (DataModel != null)
        {
            //subscribe to the event
            DataModel.DataChanged += OnDataModelChanged;

            //initial update
            UpdateDisplay(DataModel.CurrentData);
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        if (DataModel != null)
        {
            //unsubscribe to prevent memory leaks
            DataModel.DataChanged -= OnDataModelChanged;
        }            

        base.OnFormClosed(e);        
    }

    protected virtual void OnDataModelChanged(object sender, DataChangedEventArgs e)
    {
        UpdateDisplay(e.NewData??string.Empty);
    }

    protected virtual void UpdateDisplay(string data)
    {
        // Default implementation - can be overridden by derived classes
    }

}
