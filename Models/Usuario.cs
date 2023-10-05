namespace TP7_Aboudara_Garbarino_Kalinscky.Models;
public class Usuario{
    public string Contraseña;
    public string UserName;
    public string? Nombre;
    public string? Email;
    public string? Telefono; 
}

public Usuario(string UserName = "", string Contraseña = "", string Nombre = "", string Email = "", string Telefono = "") {
    this.UserName = UserName;
    this.Contraseña = Contraseña;
    this.Nombre = Nombre;
    this.Email = Email; 
    this.Telefono = Telefono;
}
