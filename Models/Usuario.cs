namespace TP09_Aboudara_Garbarino_Kalinscky.Models
{
    public class Usuario
    {
        public string Contraseña { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Usuario(){

        }
        public Usuario(string userName = "", string contraseña = "", string nombre = "", string email = "", string telefono = "0")
        {
            this.UserName = userName;
            this.Contraseña = contraseña;
            this.Nombre = nombre;
            this.Email = email;
            this.Telefono = telefono;
        }
    }
}


