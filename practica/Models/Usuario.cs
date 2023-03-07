namespace practica.Models;

public class Usuario{

    public Usuario(){

    }

    public Usuario (string name, string user, string pass){
        this.name = name;
        this.user = user;
        this.pass = pass;
    }

    public string? name {get; set;}
    public string? user {get; set;}

    public string? pass {get; set;}
}