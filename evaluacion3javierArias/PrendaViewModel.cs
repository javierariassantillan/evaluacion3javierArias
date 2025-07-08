using System.Collections.ObjectModel;

using System.Windows.Input;

using evaluacion3javierArias.Models;

using evaluacion3javierArias.Data;

using evaluacion3javierArias.Services;

using CommunityToolkit.Mvvm.ComponentModel;

using CommunityToolkit.Mvvm.Input;



namespace evaluacion3javierArias.ViewModels

{

    public partial class PrendaViewModel : ObservableObject

    {

        private readonly PrendaDatabase _db;

        private readonly LogService _logService;



        public ObservableCollection<Prenda> Prendas { get; } = new();



        [ObservableProperty] private string prendaNombre;

        [ObservableProperty] private string color;

        [ObservableProperty] private int talla;

        [ObservableProperty] private bool enInventario;



        public PrendaViewModel(PrendaDatabase db, LogService logService)

        {

            _db = db;

            _logService = logService;

            LoadPrendasCommand.Execute(null);

        }



        [RelayCommand]

        private async Task GuardarPrenda()

        {

            if (EnInventario && Talla < 10)

            {

                await Shell.Current.DisplayAlert("Error", "No se pueden registrar prendas en inventario con talla menor a 10.", "OK");

                return;

            }



            var nueva = new Prenda { PrendaNombre = PrendaNombre, Color = Color, Talla = Talla, EnInventario = EnInventario };

            await _db.SavePrendaAsync(nueva);

            await _logService.AppendLogAsync($"Se incluyó el registro [{nueva.PrendaNombre}]");

            Prendas.Add(nueva);

            LimpiarCampos();

        }



        [RelayCommand]

        private async Task LoadPrendas()

        {

            Prendas.Clear();

            var list = await _db.GetPrendasAsync();

            foreach (var item in list)

                Prendas.Add(item);

        }



        private void LimpiarCampos()

        {

            PrendaNombre = string.Empty;

            Color = string.Empty;

            Talla = 0;

            EnInventario = false;

        }

    }

}