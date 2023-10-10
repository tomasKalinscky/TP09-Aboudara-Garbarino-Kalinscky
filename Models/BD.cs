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

    public static bool Login(string username, string contraseña){
        Usuario broder;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM usuario where username = @pusername AND contraseña = @pcontraseña";
            broder = db.QueryFirstOrDefault<Usuario>(sql, new {pusername = username, pcontraseña = contraseña});
        }
        if (broder != null && !string.IsNullOrEmpty(broder.UserName)) {
        return true; 
    } else {
        return false; 
    }
    }
    public static bool RecuperarContraseña(string usuario, string contraseña){
        int n;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "UPDATE usuario SET contraseña = @pcontraseña WHERE username = @pusuario";
            n = db.Execute(sql, new {pcontraseña = contraseña, pusuario = usuario});
        }
        return n != 0;
    }
}