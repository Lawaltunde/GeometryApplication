namespace GeometryApp.GeometryAppLib;

using interfaces;

public class Square : IShape
{
    private double lenght;

    public Square(double lenght){
        this.lenght = lenght;
        
    }

    public double CalculateArear(){
        return Math.Pow(lenght, 2);
    }

    public double CalculatePerimeter(){
        return 2 * (lenght + lenght);
    }
}
