namespace GeometryApp.GeometryAppLib;

using interfaces;

public class Rectangle : IShape
{
    private double lenght;
    private double breadth;

    public Rectangle(double lenght, double breadth){
        this.lenght = lenght;
        this.breadth = breadth; 
    }

    public double CalculateArear(){
        return lenght * breadth;
    }

    public double CalculatePerimeter(){
        return 2 * (lenght + breadth);
    }
}
