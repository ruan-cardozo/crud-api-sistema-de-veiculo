using Testes.Builders.AluguelBuilder;
using Dominio.Entidades.Aluguel;
using ExpectedObjects;

namespace Testes.ProdutoTeste.Aluguel;

/*
Criteiros de Aceite
1- Deve criar um aluguel
2- Data de devolução não pode ser menor que data de retirada
3- Valor previsto não pode ser negativo
4- Valor real não pode ser negativo
5- Km de devolução não pode ser menor que km de retirada
6- Quantidade de litros de devolução não pode ser menor que quantidade de litros de retirada
7- Data prevista não pode ser menor que data de retirada
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
}