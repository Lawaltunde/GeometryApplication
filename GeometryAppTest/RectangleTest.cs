namespace GeometryApp.GeometryAppTest;

using GeometryAppLib;

[TestClass]
public class RectangleTest
{
    [TestMethod]
    public void TestArea()
    {
        Rectangle rectangle = new Rectangle(4, 5);

        //calling area method
        var result = rectangle.CalculateArear();

        //calling square method
       var result1 = rectangle.CalculatePerimeter();

        //Assert
        Assert.AreEqual(20, result);
        Assert.AreEqual(18, result1);
    }
}