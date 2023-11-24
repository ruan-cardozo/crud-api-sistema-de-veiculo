using Testes.Builders.AluguelBuilder;
using Dominio.Entidades.Aluguel;
using ExpectedObjects;

namespace Testes.ProdutoTeste.Aluguel;

/*
Criteiros de Aceite
1- Deve criar um aluguel - Done
2- Data de devolução não pode ser menor que data de retirada - Done
3- Valor previsto não pode ser negativo - Done
4- Valor real não pode ser negativo - Done
5- Km de devolução não pode ser menor que km de retirada, e não pode ser negativo - Done
6- Quantidade de litros de devolução não pode ser menor que quantidade de litros de retirada - Done
*/

public class AluguelTeste
{
    [Fact]
    public void DeveCriarAluguel()
    {
        //Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios();

        //Act
        var aluguel = AluguelBuilder.Novo().ComValoresAleatorios();

        //Assert
        aluguelEsperado.ToExpectedObject().ShouldMatch(aluguel);
    }

    /*[Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExcecaoDataDevolucaoMenorQueDataRetirada(DateOnly dataRetirada)
    {
        //Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios();     

        //Act e Assert
        Assert.Throws<ArgumentException>(() => aluguelEsperado.ComDataRetirada(dataRetirada));
    }*/

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExcecaoDataDevolucaoMenorQueDataRetirada(string dataRetiradaString)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios(); 

        // Act e Assert
        Assert.Throws<ArgumentException>(() => aluguelEsperado.ComDataRetirada(string.IsNullOrEmpty(dataRetiradaString) 
            ? DateOnly.MinValue : DateOnly.Parse(dataRetiradaString)));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]
    [InlineData(-1000)]
    [InlineData(-1.50)]
    [InlineData(-100.37)]
    [InlineData(-1000.89)]
    public void DeveLancarExcecaoValorPrevistoNegativo(decimal valorPrevisto)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios(); 

        // Act e Assert
        Assert.Throws<ArgumentException>(() => aluguelEsperado.ComValorPrevisto(valorPrevisto));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]
    [InlineData(-1000)]
    [InlineData(-1.50)]
    [InlineData(-100.37)]
    [InlineData(-1000.89)]
    public void DeveLancarExcecaoValorRealNegativo(decimal valorReal)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios(); 

        // Act e Assert
        Assert.Throws<ArgumentException>(() => aluguelEsperado.ComValorReal(valorReal));
    }

    [Fact]
    public void DeveLancarExcecaoKmDevolucaoMenorQueKmRetirada()
    {
        // Arrange
        var aluguelBuilder = AluguelBuilder.Novo().ComValoresAleatorios();
        double kmRetirada = 100;
        double kmDevolucao = 50;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => aluguelBuilder.ComKmRetirada(kmRetirada).ComKmDevolução(kmDevolucao));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]  
    [InlineData(-1000)]
    [InlineData(-1.50)]
    [InlineData(-100.37)]
    [InlineData(-1000.89)]
    public void DeveLancarExcecaoKmDevolucaoNegativo(double kmDevolucao)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios(); 

        // Act e Assert
        Assert.Throws<ArgumentException>(() => aluguelEsperado.ComKmDevolução(kmDevolucao));
    }

    [Fact]
    public void DeveLancarExcecaoQtdLtsDevolucaoMenorQueQtdLtsRetirada()
    {
        // Arrange
        var aluguelBuilder = AluguelBuilder.Novo().ComValoresAleatorios();
        double qtdLtsRetirada = 100;
        double qtdLtsDevolucao = 50;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => aluguelBuilder.ComQtdLtsRetirada(qtdLtsRetirada).ComQtdLtsDevolução(qtdLtsDevolucao));
    }



}