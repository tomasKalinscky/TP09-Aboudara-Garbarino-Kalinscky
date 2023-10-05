namespace TP7_Aboudara_Garbarino_Kalinscky.Models;
public class Usuario{
    public int IDUsuario;
    public string Contraseña;
    public string UserName;
    public string? Nombre;
    public string? Email;
    public string? Telefono; 
}

public Usuario(string UserName = "", string Contraseña = "", Nombre = "", Email = "", Telefono = "") {
    this.UserName = UserName;
    this.Contraseña = Contraseña;
    this.Nombre = Nombre;
    this.Email = Email; 
    this.Telefono = Telefono;
}
