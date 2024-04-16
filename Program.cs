
using BaltaDataAccess.Models;
using Dapper;
using Microsoft.Data.SqlClient;




const string connectionString = "Server=localhost,1433clear;Database=balta;User ID=sa;Password=Virtual0522!=@#01";

// Microsoft.Data.SqlClient


// Dapper
using (var connection = new SqlConnection(connectionString))
{
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach (var category in categories)
    {
        Console.WriteLine($"{category.Id} - {category.Title}");
    }
}


