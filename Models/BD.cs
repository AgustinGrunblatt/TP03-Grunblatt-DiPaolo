using Microsoft.Data.SqlClient;
using Dapper;

namespace TP03_Grunblatt_Dipaolo.Models;

public class BD
{
    private string _connectionString = @"Server=localhost;Database=ListaDePalabras;Integrated Security=True;TrustServerCertificate=True;";
    
    public List<string> TraerPalabras()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT palabra FROM Palabra";
            return connection.Query<string>(query).ToList();
        }
    }

   public void ArchivarPalabra(string nuevaPalabra)
{
    using (SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "INSERT INTO Palabra (palabra) VALUES (@pPalabra)";
        connection.Execute(query, new { pPalabra = nuevaPalabra });
    }
}
}