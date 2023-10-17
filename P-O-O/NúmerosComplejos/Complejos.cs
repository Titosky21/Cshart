using System;

namespace POO_Complejos{
    class Complejo : Entero{
        //Atributos
        private int parImaganaria;

        //Constructores

        public Complejo(int parteEntera,int parteImaginaria) : base(parteEntera){
            this.parImaganaria = parteImaginaria;
            Console.WriteLine("Numero : "+ this.getValor() +" + " + this.parImaganaria +"i");
        }

        public void sumaComplejos(int entero,int complejo){
            int sumaPartEntera = getValor() + entero;
            int sumaPartCompleja = parImaganaria + complejo;

            Console.WriteLine($"La suma entre [{getValor()}  {parImaganaria}i] + [{entero}  {complejo}i] es : [{sumaPartEntera}  {sumaPartCompleja}i]");
        }

        public void restaComplejos(int entero, int complejo){
            int restaPartEntera = getValor() - entero;
            int restaPartCompleja = parImaganaria - complejo;

            Console.WriteLine($"La resta entre [{getValor()}  {parImaganaria}i] - [{entero}  {complejo}i] es : [{restaPartEntera}  {restaPartCompleja}i]");
        }

        public void multiplicacionComplejos(int entero,int complejo){
            if(entero == 0 && complejo == 0 ){
                Console.WriteLine("Resultado de la multiplicación : [0 0i]");
            }else{
                int[] aux_1 = new int[2];
                aux_1[0] = getValor() * entero;
                aux_1[1] = parImaganaria * entero;

                int[] aux_2 = new int[2];
                aux_2[0] = getValor() * complejo;
                aux_2[1] = (parImaganaria * complejo) * -1;

                int real = aux_1[0] + aux_2[1];
                int imaginaria = aux_1[1] + aux_2[0];

                Console.WriteLine($"El resultado de Multiplicar [{getValor()} {parImaganaria}i] x [{entero} {complejo}i] es : [{real} {imaginaria}i]");

            }
        }

        public void divisionCompleja(int entero,int complejo){
            int[] aux_1 = new int[2];
                aux_1[0] = getValor() * entero;
                aux_1[1] = parImaganaria * entero;

                int[] aux_2 = new int[2];
                aux_2[0] = getValor() * complejo;
                aux_2[1] = (parImaganaria * complejo) * -1;

                int real = aux_1[0] + aux_2[1]*-1;
                int imaginaria = aux_1[1] + aux_2[0];

                int var = (entero * entero) - (complejo * complejo)*-1;

                Console.WriteLine($"El resultado de Dividir [{getValor()} {parImaganaria}i] / [{entero} {complejo}i] es : [{real}/{var} {imaginaria}i/{var}]");

        }

        //public override string ToString(){
        //    return $"Información del número : [{getValor()} {parImaginaria}i] \nParte Entera : {getValor()} \nParte Imaginaria : {parImaganaria}i";
        //}

    }
}
