namespace RealTimeWinFormsApp.EventArgs;

public class DataChangedEventArgs
{
    public string? NewData { get; set; }
    public DateTime Timestamp { get; set; }

    public DataChangedEventArgs(string newData)
    {
        NewData = newData;
    }
}
