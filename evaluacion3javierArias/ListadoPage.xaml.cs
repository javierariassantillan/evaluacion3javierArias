namespace evaluacion3javierArias
{
    public partial class ListadoPage : ContentPage
    {
        public ListadoPage()
        {
            InitializeComponent();
            BindingContext = new PrendaViewModel(); // Aseg�rate de tener este ViewModel
        }
    }
}
