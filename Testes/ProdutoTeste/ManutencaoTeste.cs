using Testes.Builders.ManutencaoBuilder;
using Dominio.Entidades.Manutencao;
using ExpectedObjects;

/*Critérios de Aceite
1- Deve criar uma manutenção
2- Motivo não pode ser nulo ou vazio
3- Valor não pode ser nulo ou vazio
4- Valor não pode ser menor que 0
*/

namespace Testes.ProdutoTeste.ManutencaoTeste;
public class ManutencaoTeste
{
    [Fact]
    public void DeveCriarManutencao()
    {
        //Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios();

        //Act
        var manutencao = ManutencaoBuilder.Novo().ComValoresAleatorios();

        //Assert
        manutencaoEsperada.ToExpectedObject().ShouldMatch(manutencao);
    }
}
