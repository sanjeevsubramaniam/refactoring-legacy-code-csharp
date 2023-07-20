namespace Tests;

public class CustomerTest
{
    [Fact]
    public void Test1()
    {
        string myname = "Hello" + " Test!";
        Assert.Equal("Hello Test!", myname);


    }
}
