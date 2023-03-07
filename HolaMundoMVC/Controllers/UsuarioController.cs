using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;

namespace HolaMundoMVC.Controllers;

public class UsuarioController : Controller{


    public IActionResult Index(){

        ViewBag.nombre = "gerson";
        ViewData["apellido"] = "belteton";

        List<String> nombres = new List<String>(){"gerson","juan","alejandro"};

        ViewBag.nombres = nombres;
        return View();
    }

    public IActionResult ListaUsuarios(){

        List<Usuario> usuarios = new List<Usuario>(){
            new Usuario("gerson","apellido", 24),
            new Usuario("alejandro","urbina", 23),
            new Usuario("kristel","cruz", 19),
            new Usuario(){
                nombre = "jorge",
                apellido = "guzman",
                edad = 42
            }
        };

        ViewBag.usuarios = usuarios;
        return View();
    }
}