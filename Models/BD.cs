using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP09-Aboudara-Garbarino_Kalinscky.Models;


public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=base_de_datos-TP09;Trusted_Connection=True;";

    public static int RegistrarUsuario(Usuario us){
        int n;
        using (SqlConnection)
    }

}