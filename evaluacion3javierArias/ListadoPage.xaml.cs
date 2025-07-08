namespace evaluacion3javierArias
{
    public partial class ListadoPage : ContentPage
    {
        public ListadoPage()
        {
            InitializeComponent();
            BindingContext = new PrendaViewModel(); // Asegúrate de tener este ViewModel
        }
    }
}
