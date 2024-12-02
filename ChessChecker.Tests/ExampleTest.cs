namespace ChessChecker.Tests;

using NUnit.Framework;
using ChessChecker;

public class Tests
{
    private Example _example;
    [SetUp]
    public void Setup()
    {
        _example = new(5);
    }

    [Test]
    public void Test1()
    {
        Assert.True(_example.IsOdd());
        Assert.IsFalse(_example.IsEven());
    }
}