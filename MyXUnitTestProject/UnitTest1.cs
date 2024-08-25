namespace MyXUnitTestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2, 2);
        Assert.Equal(4, result);

    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

