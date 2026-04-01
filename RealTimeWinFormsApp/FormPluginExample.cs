using RealTimeWinFormsApp.BaseClasses;
using RealTimeWinFormsApp.EventArgs;
using RealTimeWinFormsApp.Models;

namespace RealTimeWinFormsApp;

public partial class FormPluginExample : DataViewBase
{
    private int updateCount = 0;

    public FormPluginExample(SharedDataModel dataModel) 
        : base(dataModel)

    {
        InitializeComponent();
    }

    protected override void OnDataModelChanged(object sender, DataChangedEventArgs e)
    {
        updateCount++;
        UpdateDisplay(e.NewData);
    }

    protected override void UpdateDisplay(string data)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => UpdateLabel(data)));
        }
        else
        {
           UpdateLabel(data);
        }
    }

    private void UpdateLabel(string data)
    {
        label1Plugin.Text = $"Updates: {updateCount} - Latest {data}";
    }

}
