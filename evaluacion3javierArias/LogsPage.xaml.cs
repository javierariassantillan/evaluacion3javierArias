namespace evaluacion3javierArias;

public partial class LogsPage : ContentPage
{
    public LogsPage()
    {
        InitializeComponent();
        LogsListView.ItemsSource = LogService.ObtenerLogs(); // Aseg�rate de que esta funci�n devuelva una lista de strings
    }
}
