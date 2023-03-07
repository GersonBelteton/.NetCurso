namespace HolaMundoMVC.Models;

public class Usuario{
    
    public Usuario(string nombre, string apellido, int edad){
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    }

    public Usuario(){}
    public string? nombre{get; set;}
    public string? apellido{get; set;}

    public int edad {get; set;}
}