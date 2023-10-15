using System;

namespace cuentaBanco{
class cuentaBanco{
    //Atributos

    private string nombre;
    private string cuenta;
    private double saldo;
    private double tipoDeInteres;

    public void asignarNombre(string nomb){
        if(nomb.Lenght = 0){
            Console.WriteLine("ERROR: cadena vacía");
            return ; 
        }
        this.nombre=nomb;
    }

    public string obtenerNombre(){
        return this.nombre;
    }

    public double estado(){
        return this.saldo;
    }

    public void asignarCuenta(string cuenta){
        if(cuenta.Lenght == 0 ){
            Console.WriteLine("ERROR: cadena vacía");
            return ; 
        }
        this.cuenta=cuenta;
    }

    public string obtenerCuenta(){
        return this.cuenta;
    }

    public void Deposito(double cantidad){
        if(cantidad < 0 ){
            Console.WriteLine("ERROR: cantidad negativa");
            return ; 
        }
        this.saldo = saldo + cantidad;
    }

    public void Retiro(double cantidad){
        if(cantidad < 0 ){
            Console.WriteLine("ERROR: cantidad negativa");
            return ;
        }
        this.saldo = saldo - cantidad;
    }

    public void asignarInteres(double tipo){
        if (tipo < 0 ){
            Console.WriteLine("ERROR: tipo no válido");
            return ;
        }
        this.tipoDeInteres=tipo;
    }

    public double obtenerInteres(){
        return this.tipoDeInteres;
    }
}
}

