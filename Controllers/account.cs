using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09_Aboudara_Garbarino_Kalinscky.Models;
public class account : Controller
{
    private readonly ILogger<account> _logger;
    
    public IActionResult registro() {
        return View("Index");
    }

    public IActionResult olvide() {
        return View("olvide");
    }

    public IActionResult login() {
        return View("Index");
    }
}