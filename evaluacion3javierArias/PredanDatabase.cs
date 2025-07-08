using SQLite;

using evaluacion3javierArias.Models;



namespace evaluacion3javierArias.Data

{

    public class PrendaDatabase

    {

        private readonly SQLiteAsyncConnection _database;



        public PrendaDatabase(string dbPath)

        {

            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<Prenda>().Wait();

        }



        public Task<List<Prenda>> GetPrendasAsync() => _database.Table<Prenda>().ToListAsync();

        public Task<int> SavePrendaAsync(Prenda item) => _database.InsertAsync(item);

    }

}