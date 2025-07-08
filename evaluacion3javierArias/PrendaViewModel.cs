using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace evaluacion3javierArias;

public partial class PrendaViewModel : ObservableObject
{
    public ObservableCollection<Prenda> Prendas { get; set; } = new();

    [ObservableProperty]
    private string prendaNombre = string.Empty;

    [ObservableProperty]
    private string color = string.Empty;

    private readonly PrendaDatabase _database;

    public PrendaViewModel()
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "prendas.db3");
        _database = new PrendaDatabase(dbPath);
        CargarPrendas();
    }

    [RelayCommand]
    private async void Agregar()
    {
        var nuevaPrenda = new Prenda
        {
            PrendaNombre = PrendaNombre,
            Color = Color
        };

        await _database.SavePrendaAsync(nuevaPrenda);
        Prendas.Add(nuevaPrenda);
        PrendaNombre = string.Empty;
        Color = string.Empty;
    }

    private async void CargarPrendas()
    {
        var lista = await _database.GetPrendasAsync();
        foreach (var item in lista)
        {
            Prendas.Add(item);
        }
    }
}
