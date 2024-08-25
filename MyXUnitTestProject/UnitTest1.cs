namespace MyXUnitTestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);

    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

