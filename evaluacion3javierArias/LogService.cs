using System.Text;



namespace evaluacion3javierArias.Services

{

    public class LogService

    {

        private readonly string logPath;



        public LogService(string apellido)

        {

            string fileName = $"Logs_{apellido}.txt";

            logPath = Path.Combine(FileSystem.AppDataDirectory, fileName);

        }



        public async Task AppendLogAsync(string mensaje)

        {

            var logEntry = $"{mensaje} el {DateTime.Now:dd/MM/yyyy HH:mm}\n";

            await File.AppendAllTextAsync(logPath, logEntry, Encoding.UTF8);

        }



        public async Task<string> ReadLogsAsync()

        {

            return File.Exists(logPath) ? await File.ReadAllTextAsync(logPath) : "No hay logs aún.";

        }

    }

}