[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void IsEquilateral()
    {
        Assert.AreEqual(TriangleType.Equilateral, Triangle(5, 5, 5));
    }

    [TestMethod]
    public void IsIsosceles()
    {
        Assert.AreEqual(TriangleType.Isosceles, Triangle(5, 5, 7));
    }

    [TestMethod]
    public void IsScalene()
    {
        Assert.AreEqual(TriangleType.Scalene, Triangle(5, 6, 7));
    }

    public  TriangleType Triangle(int sideA, int sideB, int side3)
    {
        
    }
}

//Write This Function
 public  TriangleType Triangle(int sideA, int sideB, int side3)
{
    
}    