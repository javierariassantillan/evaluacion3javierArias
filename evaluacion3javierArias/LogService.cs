namespace evaluacion3javierArias;

public static class LogService
{
    public static List<string> ObtenerLogs()
    {
        return new List<string>
        {
            "Aplicación iniciada",
            "Usuario autenticado",
            "Base de datos conectada",
            "Error al guardar",
            "Sesión finalizada"
        };
    }
}
