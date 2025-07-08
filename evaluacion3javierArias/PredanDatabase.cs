using SQLite;

namespace evaluacion3javierArias;

public class PrendaDatabase
{
    readonly SQLiteAsyncConnection _database;

    public PrendaDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Prenda>().Wait();
    }

    public Task<List<Prenda>> GetPrendasAsync()
    {
        return _database.Table<Prenda>().ToListAsync();
    }

    public Task<int> SavePrendaAsync(Prenda prenda)
    {
        return _database.InsertAsync(prenda);
    }
}
