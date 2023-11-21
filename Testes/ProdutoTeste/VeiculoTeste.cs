
using Testes.Builders.VeiculoBuilder;
using Dominio.Entidades.Veiculo;
using ExpectedObjects;
using Testes.ArgExcextensions;

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
    public void DeveLancarExececaoAoCriarVeiculoComPlacaNula(string placa)
    {
        // Arrange
        var veiculoBuilder = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoBuilder.ComPlaca(placa));
    }
}