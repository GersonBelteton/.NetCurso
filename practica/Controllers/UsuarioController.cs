using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica.Models;

namespace practica.Controllers;

public class UsuarioController : Controller{

    public IActionResult Index(){
        return View();
    }

    public IActionResult ListaUsuarios(){

        List<Usuario> usuarios = new List<Usuario>(){
            new Usuario("Gerson","ger","123"),
            new Usuario("Alejandro","ale","123")
        };

        ViewBag.usuarios = usuarios;

        return View();
    }
}