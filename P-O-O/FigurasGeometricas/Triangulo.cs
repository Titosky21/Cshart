
class Triangulo : FigGeo{
    //Atributos
    private double lado1, lado2, lado3;

    //constructores
    public Triangulo(double lado1, double lado2, double lado3){
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    //Métodos
    //override : para sobre escribir metodos de otras clases no necesariamente de una clase abstracta
    public override double Perimetro(){
        return (this.lado1*this.lado2*this.lado3);
    }

    public override double area(){
        double semiPerim = Perimetro / 2; 
        double altura = (2/this.lado1) * Math.Sqrt((semiPerim*(semiPerim-this.lado1) * (semiPerim-this.lado2)*(semiPerim-this.lado3)));
        double area = (altura * this.lado1)/2;
        return area;
    }

}
