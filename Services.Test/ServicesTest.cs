using Services.Services;

namespace Services.Test;

public class Tests
{
    private DesafioServices _services;

    [SetUp]
    public void Setup()
    {
        _services = new DesafioServices();
    }

    [TestCase(0)]
    [TestCase(1)]
    [TestCase(4)]
    public void NumeroPrimo_DeveRetornarFalsoPoisNaoSaoPrimos(int numero)
    {
        var result = _services.NumeroPrimo(numero);
        Assert.IsFalse(result);
    }

    [Test]
    public void AcharDivisores_DeveRetornarTruePoisListaCerta()
    {
        var result = _services.AcharDivisores(10);
        Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 5, 10 }));
    }

    //[TestCase(10, ExpectedResult = new List<int>{1,2,5,10}, TestName="Divisores de 10")]
    //public List<int> AcharDivisores_DeveRetornarTruePoisListaCorreta(int numero)
    //{
    //    return _services.AcharDivisores(numero);
    //}

    [Test]
    public void AcharDivisoresPrimos_DeveRetornarTruePoisListaCerta()
    {
        var result = _services.AcharDivisoresPrimos(new List<int> { 1, 2, 5, 10});
        Assert.That(result, Is.EqualTo(new List<int> {2,5 }));
    }
}