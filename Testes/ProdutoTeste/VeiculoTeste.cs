
using Testes.Builders.VeiculoBuilder;
using Dominio.Entidades.Veiculo;
using ExpectedObjects;
using Testes.ArgExcextensions;
using Dominio.Enums.MarcaEnum;

//Criterios de aceite
/*
1. Placa nao pode ser nula nem vazia - Done
2. Placa deve conter 7 caracteres - Done
3. anoFab não pode execeder 1900 - Done
4. km não pode ser menor que 0 - Done
5. numChassi não pode ser nulo nem vazio - Done
6. numChassi deve conter 11 caracteres
7. marca não pode ser nula
*/

namespace Testes.ProdutoTeste.VeiculoTeste;

public class VeiculoTeste
{
    [Fact]
    public void DeveCriarVeiculo()
    {
        //Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        //Act
        var veiculo = VeiculoBuilder.Novo().ComValoresAleatorios();

        //Assert
        veiculoEsperado.ToExpectedObject().ShouldMatch(veiculo);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoComPlacaNulaEVazia(string placa)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComPlaca(placa));
    }

    [Theory]
    [InlineData("HPSAD046")]
    [InlineData("HPS-04656")]
    [InlineData("HPS-0465-")]
    [InlineData("HPS-0465-1")]
    [InlineData("HPS-0465-12")]
    [InlineData("HPS-0465-123")]
    public void PlacaNaoDeveAceitarValoresDiferentesDe7Caracteres(string placa)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComPlaca(placa));
    }

    [Theory]
    [InlineData(1899)]
    public void DeveLancarExececaoAoCriarVeiculoComAnoFabMenorQue1900(int anoFab)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComAnoFab(anoFab));
    }

    [Theory]
    [InlineData(-1.15)]
    [InlineData(-150.25)]
    [InlineData(-0.5)]
    [InlineData(-0.0001)]
    public void DeveLancarExececaoAoCriarVeiculoComKmNegativo(double km)
    {
        // Arrange
        var veiculoBuilder = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoBuilder.ComKm(km));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoComNumChassiNulaEVazia(string numChassi)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComNumChassi(numChassi));
    }


}