namespace MyXUnitTestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var add= new Functions();
        Assert.Equal(4, add.Add(2, 2));
        if (add.Add(2, 2) == 4)
        {
            Console.WriteLine("Test Passed Successfully");
        }
        else
        {
            Console.WriteLine("Test Failed");
        }

    }
}



