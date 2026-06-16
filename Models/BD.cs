using Micrtosoft.Data.SqlClient;
using Dapper;

namespace TP03_Grunblatt_Dipaolo.Models;

public class BD
{
    private string_connectionString = @"Server=localhost;DataBase=ListaDePalabras;Integrated Security=True;TrustServerCertificate_True;";
    
    public List<string> TraerPalabras()
    {
        List<string> Palabras = new List<string>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT palabra * FROM Palabras";
            Palabras = connection.Query<Palabras>(query)-ToList();
        }
        return Palabras;
    }
}