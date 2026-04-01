using RealTimeWinFormsApp.BaseClasses;
using RealTimeWinFormsApp.EventArgs;
using RealTimeWinFormsApp.Models;

namespace RealTimeWinFormsApp;

public partial class FormSecondary : DataViewBase
{
    public FormSecondary(SharedDataModel dataModel)
        : base(dataModel)
    {
        InitializeComponent();
    }

    protected override void OnDataModelChanged(object sender, DataChangedEventArgs e)
    {
        UpdateDisplay(e.NewData);
    }

    protected override void UpdateDisplay(string data)
    {
        if (!string.IsNullOrWhiteSpace(data))
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
    }

    private void UpdateLabel(string data)
    {
        lblDataSecondaryView.Text = $"Data: {data} at {DateTime.Now:T}";
    }
}



