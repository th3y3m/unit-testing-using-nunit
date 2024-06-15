namespace PrimeService.Tests;

[TestFixture]
public class PrimeService_IsPrimeShould
{
    private PrimeService _primeService;

    [SetUp]
    public void SetUp()
    {
        _primeService = new PrimeService();
    }

    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
        var result = _primeService?.IsPrime(value);

        Assert.That(result, Is.False, $"{value} should not be prime");
    }

    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(9)]
    public void IsPrime_NonPrimeValues_ReturnFalse(int value)
    {
        var result = _primeService?.IsPrime(value);

        Assert.That(result, Is.False, $"{value} should not be prime");
    }

    [TestCase(5)]
    public void IsPrime_PrimeValue_ReturnTrue(int value)
    {
        var result = _primeService?.IsPrime(value);

        Assert.That(result, Is.True, $"{value} should be prime");
    }



}