using System;

namespace Productos{
    class Producto{
        private int codigo;
        private string nombre;
        private double precio;
        private int stock;

        //Constructores
        public Producto(){

        }

        public Producto(int codigo, string nombre, double precio,int stock){
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        //Metodos Get;

        public double getPrecio(){ //es publico para así poder llamarlo de otra clase, es double porque devuelve un numero
            return precio; //retorna el numero que esta guardado.
        }
        //Metodo Set;

        public void setPrecio(double precio){
            this.precio = precio;
        }
        //Metodo set;
        public void setStock(int nuevoStock){
            stock = nuevoStock; //aqui si se quiere se puede usar o no el "this." ya que el parametro es un nombre distitnto
        }

        //metodo para comprar un producto

        public void comprar(int cantidad){
            if(cantidad <= stock){
                Console.WriteLine($"Compra realizada : {cantidad} unidades de {nombre}");
                stock -= cantidad;
            }else {
                Console.WriteLine($"La cantidad de unidades {cantidad} es mayor que el stok");
            }
        }

        //Metodo get para mostrar nombre

        public string setNombre(string nombre){
            return this.nombre = nombre;// this.nombre = nombre;
        }
        
        //Metodo get para mostrar nombre

        public string getNombre(){
            return this.nombre;
        }
        //metodo getter para mostrar informacion del producto

        public void getInfo(){
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Stock Disponible: {stock}");
        }

    }
}
