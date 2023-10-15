using System;

namespace POO_NumNaturales{
public class NumerosN{
    //Atributos : como esta formado (característica)

    private int valor;

    //Constructores : funcion iniciar un objeto con argumentos desde el principio

    public NumerosN(int num){
        if (num < 0 ){
            this.valor = num * (-1);
            Console.WriteLine("EL número ingresado es negativo, se ha cambiado a positivo");
        }
        this.valor = num ;
    }

    public NumerosN(){

    }

    //Metodos : lo que puede hacer (acciones)
    
    public void Suma(int num){
        this.valor = this.valor + num;
        if(this.valor < 0 ){
            this.valor = num * (-1);
            Console.WriteLine("Resultado de la suma negativo, se cambio a positivo");
        }
        Console.WriteLine($"Al sumar {num} resulta : {this.valor}");
    }

    public void Resta(int num){
        this.valor = this.valor - num;
        if (this.valor < 0 ){
            this.valor = this.valor * (-1);
        }
        Console.WriteLine($"Al restar {num} resulta : {this.valor}");
    }

    public void Multiplicacion(int num){
        this.valor = this.valor * num ;
        if (this.valor < 0 ){
            this.valor = this.valor * (-1);
        }
        Console.WriteLine($"Al multiplicar {num} resulta : {this.valor}");
    }

    public void Division(int num){
        if(num == 0){
            Console.WriteLine("No se puede dividir por cero");
        }   
        this.valor = this.valor / num;
        Console.WriteLine($"Al dividir {num} resultado : {this.valor} ");
    }

    public void esPar(){
        if (this.valor % 2 == 0){
            Console.WriteLine($"El número {this.valor} es Par");
        }else{
        Console.WriteLine($"El número {this.valor} no es Par");
        }
    }

    public void esPrimo(){
        if(this.valor <= 1){
            Console.WriteLine($"{this.valor} los primos comienzan del 2");
        }
        for(int i = 2 ; i * i <= this.valor ; i++){
            if (this.valor % i <= 0 ){
                //Console.WriteLine($"El valor {this.valor} no es Primo");
            }
        }
        Console.WriteLine($"El número {this.valor} es Primo");
    }

}
}

