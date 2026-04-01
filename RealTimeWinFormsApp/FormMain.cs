using RealTimeWinFormsApp.BaseClasses;
using RealTimeWinFormsApp.EventArgs;
using RealTimeWinFormsApp.Models;

namespace RealTimeWinFormsApp;

public partial class FormMain : DataViewBase
{
    public FormMain(SharedDataModel dataModel)
         : base(dataModel)
    {
        InitializeComponent();
    }

    protected override void OnDataModelChanged(object sender, DataChangedEventArgs e)
    {
        UpdateDisplay(e.NewData??string.Empty);
    }

    protected override void UpdateDisplay(string data)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => textDataMainForm.Text = data));
        }
        else
        {
            textDataMainForm.Text = data;
        }

    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        DataModel.CurrentData = textDataMainForm.Text;
    }
}
