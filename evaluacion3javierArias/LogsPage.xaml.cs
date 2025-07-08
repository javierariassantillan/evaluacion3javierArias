namespace evaluacion3javierArias;

public partial class LogsPage : ContentPage
{
    public LogsPage()
    {
        InitializeComponent();
        LogsListView.ItemsSource = LogService.ObtenerLogs(); // Asegúrate de que esta función devuelva una lista de strings
    }
}
