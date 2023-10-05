using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;


namespace TP09_Aboudara_Garbarino_Kalinscky.Models;


public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=base_de_datos-TP09;Trusted_Connection=True;";

    public static bool RegistrarUsuario(Usuario us){
        int n;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "INSERT INTO usuario (username, contraseña, email, telefono, nombre) VALUES (@pusername, @pcontraseña, @pemail, @ptelefono, @pnombre)";
            n = db.Execute(sql, new {pusername = us.UserName, pcontraseña = us.Contraseña, pemail = us.Email, ptelefono = us.Telefono, pnombre = us.Nombre});
        }
        return n != 0;
    }

    public static bool Login(string usuario, string contraseña){
        Usuario broder;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM usuario where username = @pusername AND contraseña = @pcontraseña";
            broder = db.QueryFirstOrDefault<Usuario>(sql, new {pusername = usuario, pcontraseña = contraseña});
        }
        return broder.UserName == null || broder.UserName == "";
    }

    public static bool RecuperarContraseña(string usuario, string contraseña){
        int n;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "UPDATE usuario SET contraseña = @pcontraseña WHERE usuario = @pusuario";
            n = db.Execute(sql, new {pcontraseña = contraseña, pusuario = usuario});
        }
        return n != 0;
    }
}