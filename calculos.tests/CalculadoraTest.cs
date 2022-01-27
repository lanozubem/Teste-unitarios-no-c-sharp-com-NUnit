// Referência -> https://www.treinaweb.com.br/blog/teste-unitarios-no-c-com-o-nunit

using NUnit.Framework;

namespace calculos.tests;

[TestFixture]
public class CalculadoraTest
{
    [Test]
    public void Soma_DeveRetornarOValorCorreto()
    {
        var c = new Calculadora();
        var resultado = c.Soma(10, 20);
        //Verifica se o resultado é igual a 30

        Assert.That(30, Is.EqualTo(resultado));
    }

    [Test]
    public void Divisao_DeveRetornarOValorCorreto()
    {
        var c = new Calculadora();
        var resultado = c.RestoDivisao(10, 3);
        //Verifica se o quociente da divisão é 3 e o resto 1
        Assert.Multiple(() =>
        {
            Assert.That(3, Is.EqualTo(resultado.quociente));
            Assert.That(1, Is.EqualTo(resultado.resto));
        });
    }

    //Múltiplos testes
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void RestoDivisao_DeveRetornarZero(int value)
    {
        var c = new Calculadora();
        var resultado = c.RestoDivisao(12, value);
        //Verifica se o resto da divisão é 0
        Assert.That(0, Is.EqualTo(resultado.resto));
    }

    [Test]
    public void Subtracao_DeveRetornarOValorCorreto()
    {
        var c = new Calculadora();
        var resultado = c.Subtracao(20, 10);
        //Verifica se o resultado é igual a 10
        Assert.That(10, Is.EqualTo(resultado));
    }

    [Test]
    public void Multiplicacao_DeveRetornarOValorCorreto()
    {
        var c = new Calculadora();
        var resultado = c.Multiplicacao(5, 2);
        //Verifica se o resultado é igual a 10
        Assert.That(10, Is.EqualTo(resultado));
    }
}