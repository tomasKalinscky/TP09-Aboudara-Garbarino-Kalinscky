using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09_Aboudara_Garbarino_Kalinscky.Models;
public class account : Controller
{
    private readonly ILogger<account> _logger;
    
    public IActionResult registro(string usuario, string contraseña, string email, string nombre, string telefono) {
        Usuario nuevoUsuario = new Usuario(usuario, contraseña, email, nombre, telefono);
        BD.RegistrarUsuario(nuevoUsuario);
        return View("Index");
    }

    public IActionResult olvide() {
        return View("olvide");
    }

    public IActionResult login(string usuario, string contraseña) {
        if (BD.Login(usuario, contraseña)) {
            ViewBag.usuario = usuario;
            return View("bienvenida");
        }
        return View("Index");
    }
}