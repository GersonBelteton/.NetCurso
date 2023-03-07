using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica.Models;
using System.Linq;
namespace practica.Controllers;

public class HomeController : Controller
{

    EmpleadoCTX ctx;

    public HomeController(EmpleadoCTX _context){
        ctx = _context;
    }

    public IActionResult Index()
    {
        ViewBag.Empleados = ctx.Trabajador.ToList();
        return View();
    }


    [BindProperty]
    public Empleado? Empleado {get; set;}
    public IActionResult setUsuario(){
        return Json(Empleado);
    }


}
