// This file was auto-generated based on version 1.2.0 of the canonical data.

using Xunit;

public class SpaceAgeTest
{
    [Fact]
    public void Age_on_earth()
    {
        var sut = new SpaceAge(1_000_000_000);
        Assert.Equal(31.69, sut.OnEarth(), precision: 2);
    }

    [Fact]
    public void Age_on_mercury()
    {
        var sut = new SpaceAge(2_134_835_688);
        Assert.Equal(280.88, sut.OnMercury(), precision: 2);
    }

    [Fact]
    public void Age_on_venus()
    {
        var sut = new SpaceAge(189_839_836);
        Assert.Equal(9.78, sut.OnVenus(), precision: 2);
    }

    [Fact]
    public void Age_on_mars()
    {
        var sut = new SpaceAge(2_129_871_239);
        Assert.Equal(35.88, sut.OnMars(), precision: 2);
    }

    [Fact]
    public void Age_on_jupiter()
    {
        var sut = new SpaceAge(901_876_382);
        Assert.Equal(2.41, sut.OnJupiter(), precision: 2);
    }

    [Fact]
    public void Age_on_saturn()
    {
        var sut = new SpaceAge(2_000_000_000);
        Assert.Equal(2.15, sut.OnSaturn(), precision: 2);
    }

    [Fact]
    public void Age_on_uranus()
    {
        var sut = new SpaceAge(1_210_123_456);
        Assert.Equal(0.46, sut.OnUranus(), precision: 2);
    }

    [Fact]
    public void Age_on_neptune()
    {
        var sut = new SpaceAge(1_821_023_456);
        Assert.Equal(0.35, sut.OnNeptune(), precision: 2);
    }
}