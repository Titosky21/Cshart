//CÓDIGO DE LA MÁQUINA DE TURING

using System;
using FinalTeoria;

namespace FinalTeoria{
    public class MaquinaTuring{

        //Atributos
        private char[] cinta;
        private string cadena;

        //Constructor
        public MaquinaTuring(string cosa){
            this.cadena = cosa;
            this.cinta = new char[cadena.Length+2];
        }

        //Métodos
        public char[] PasarAChar(){

            int var=cadena.Length;
            for(int i = 0 ; i < cadena.Length ; i++){
                cinta[i] = cadena[i] ;
                if(i==0){
                    cinta[i] = '-';
                }
            }
            cinta[var+1] = '-';
            Console.Write($"\n|-----------------------------------------------------------------------|\n");
            return cinta;
        }
        //Mostrar Cinta 
        public void MostrarCinta(char[] varCinta){
            Console.Write("[");
            for(int i = 0 ; i < varCinta.Length ; i++){
                cinta[i] = varCinta[i] ;
                Console.Write(varCinta[i]+", ");
            }
            Console.Write("]");
            Console.Write($"\n|-----------------------------------------------------------------------|\n");
        }

        //ESTADOS
        public void Inicio(int var){
            int i = var ;

            if(cinta[i]=='a'){
                cinta[i]='-';
                i++;

                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO 1");

                Estado_1(i);
                //debemos poner un for que recorra transiciones
            }if(cinta[i]=='b'){
                cinta[i]='-';

                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO DE ACEPTACIÓN");

                Aceptacion();
            }if(cinta[i]=='-'){
                cinta[i]='a';
                
                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO DE ACEPTACIÓN");

                Aceptacion();
            }
        }
        public void Estado_1(int var){
            int i = var ;
            
            if(cinta[i]=='a'){
                cinta[i]='a';
                i++;

                //MostrarCinta(cinta);
                //Console.WriteLine("VOLVEMOS AL ESTADO 1");

                Estado_1(i);
            }if(cinta[i]=='b'){
                cinta[i]='b';
                i++;

                //MostrarCinta(cinta);
                //Console.WriteLine("VOLVEMOS AL ESTADO 1");

                Estado_1(i);
            }if(cinta[i]=='-'){
                cinta[i]='-';
                i--;

                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO 2");
                
                Estado_2(i);
            }
        }

        public void Estado_2(int var){
            int i = var ;
           
            if(cinta[i]=='a'){
                cinta[i]='-';

                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO DE ACEPTACIÓN");

                Aceptacion();
            }if(cinta[i]=='b'){
                cinta[i]='-';
                i--;
                
                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO 3");

                Estado_3(i);
            }if(cinta[i]=='-'){
                cinta[i]='-';

                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO DE ACEPTACIÓN");

                Aceptacion();
            }
        }

        public void Estado_3(int var){
            int i = var ;
            
            if(cinta[i]=='a'){
                cinta[i]='a';
                i--;

                //MostrarCinta(cinta);
                //Console.WriteLine("VOLVEMOS AL ESTADO 3");

                Estado_3(i);
                }if(cinta[i]=='b'){
                cinta[i]='b';
                i--;

                //MostrarCinta(cinta);
                //Console.WriteLine("VOLVEMOS AL ESTADO 3");

                Estado_3(i);
            }if(cinta[i]=='-'){
                cinta[i]='-';
                i++;

                //MostrarCinta(cinta);
                //Console.WriteLine("VAMOS AL ESTADO DE INICIO");

                Inicio(i);
            }
        }

        public void Aceptacion(){
            //hacer for para ver si la cinta se encuentra vacia
            Menu mn = new Menu();
            
            Console.Write("Cadena: "+cadena);

            if(cinta[1]=='-'){
                for(int i = 0 ; i < cinta.Length ; i++){
                    if(cinta[i]=='a' || cinta[i]=='b'){
                        Console.WriteLine("\n---CADENA NO ACEPTADA---");
                        MostrarCinta(cinta);
                        //Environment.Exit(0);
                        //mn.MostrarMenu();
                    }
                }
                Console.WriteLine("\n---CADENA ACEPTADA---");
                MostrarCinta(cinta);
                //mn.MostrarMenu();
            }
            //Environment.Exit(0);
        }
        
    }
}
