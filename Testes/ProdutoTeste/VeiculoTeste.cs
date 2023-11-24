
using Testes.Builders.VeiculoBuilder;
using ExpectedObjects;

//Criterios de aceite
/*
1. Placa nao pode ser nula nem vazia
2. Placa deve conter 7 caracteres
3. anoFab não pode execeder 1900
4. km não pode ser menor que 0
5. numChassi não pode ser nulo nem vazio
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
    [InlineData(null)]
    public void DeveLancarExececaoAoCriarVeiculoComKmNegativo(double km)
    {
        // Arrange
        var veiculoBuilder = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoBuilder.ComKm(km));
    }
}