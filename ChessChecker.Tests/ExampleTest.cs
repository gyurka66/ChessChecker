namespace ChessChecker.Tests;

public class Tests
{
    private Example? _example;

    [SetUp]
    public void Setup()
    {
        _example = new(5);
    }

    [Test]
    public void Test1()
    {
        Assert.That(_example!.IsOdd, Is.True);
        Assert.That(_example!.IsEven(), Is.False);
    }
}
