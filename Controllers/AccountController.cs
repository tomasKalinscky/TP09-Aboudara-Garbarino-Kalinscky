using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09_Aboudara_Garbarino_Kalinscky.Models;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    
       [HttpPost]
    public IActionResult registro(Usuario nuevoUsuario) {
         
        BD.RegistrarUsuario(nuevoUsuario);
        return View("Index");
    }

    public IActionResult olvide(string usuario, string contraseña) {
        BD.RecuperarContraseña(usuario, contraseña);
        return View("Index");
    }

    [HttpPost]
  public IActionResult login(string usuario, string contraseña) {
    if (BD.Login(usuario, contraseña)) {
        ViewBag.usuario = usuario;
        return  RedirectToAction("Bienvenida", "Home");
    }

    return RedirectToAction("Index", "Home", new {user = true});
}

}