using RealTimeWinFormsApp.EventArgs;

namespace RealTimeWinFormsApp.Models;

public class SharedDataModel
{
    private string _currentData;

    public event EventHandler<DataChangedEventArgs> DataChanged;

    public string CurrentData { 
        get => _currentData;
        set
        {
            if(_currentData != value)
            {
                _currentData = value;
                OnDataChanged(new DataChangedEventArgs(value));
            }
        } 
    }

    private void OnDataChanged(DataChangedEventArgs e)
    {
        DataChanged?.Invoke(this, e);
    }
}
