namespace GeometryApp.GeometryAppTest;
using GeometryAppLib;

[TestClass]
public class SquareTests
{
    
    [TestMethod]
    public void TestArea()
    {
        Square square = new Square(5);
        //calling area method
        var result = square.CalculateArear();

        //calling square method: Act
        var result2 = square.CalculatePerimeter();

        //Assert
        Assert.AreEqual(25, result);
        Assert.AreEqual(20, result2);
    }
}