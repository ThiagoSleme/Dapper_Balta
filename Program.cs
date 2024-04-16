
using BaltaDataAccess.Models;
using Dapper;
using Microsoft.Data.SqlClient;




const string connectionString = "Server=localhost,1433;Database=balta;User Id=sa;Password=Virtual0522!=@#01; TrustServerCertificate=True; Trusted_Connection=True;";

// Microsoft.Data.SqlClient


// Dapper
using (var connection = new SqlConnection(connectionString))
{
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach (var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }

}


