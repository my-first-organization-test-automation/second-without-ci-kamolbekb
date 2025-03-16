namespace tests;

using Xunit;
using AddNumbersTask;

public class AddNumbersTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(5, AddNumbers.Add(2, 3));
        Assert.Equal(0, AddNumbers.Add(0, 0));
        Assert.Equal(-3, AddNumbers.Add(-1, -2));
    }
}
