using SQLite;



namespace evaluacion3javierArias.Models

{

    public class Prenda

    {

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string PrendaNombre { get; set; }

        public string Color { get; set; }

        public int Talla { get; set; }

        public bool EnInventario { get; set; }

    }

}