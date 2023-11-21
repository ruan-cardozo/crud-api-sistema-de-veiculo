
using Testes.Builders.VeiculoBuilder;
using Dominio.Enums.MarcaEnum;
using Dominio.Enums.ModeloEnum;
using Dominio.Entidades.Veiculo;
using Testes.ArgExcextensions;
using ExpectedObjects;

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
}