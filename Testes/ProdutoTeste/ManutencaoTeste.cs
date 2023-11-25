using Testes.Builders.ManutencaoBuilder;
using Dominio.Entidades.Manutencao;
using ExpectedObjects;

/*Critérios de Aceite
1- Deve criar uma manutenção - Done
2- Motivo não pode ser nulo ou vazio - Done
3- Valor não pode ser menor que 0 - Done
4-  id_aluguel não pode ser menor que 0
5-  id não pode ser menor que 0
6- Motivo deve ter entre 5 e 50 caracteres
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

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExcecaoComMotivoNuloOuVazio(string motivo)
    {
        //Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios();     

        //Act e Assert
        Assert.Throws<ArgumentException>(() => manutencaoEsperada.ComMotivo(motivo));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    public void DeveLancarExcecaoComValorNegativo(decimal valorInvalido)
    {
        //Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios(); 

        //Act e Assert
        Assert.Throws<ArgumentException>(() => manutencaoEsperada.ComValor(valorInvalido));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    public void DeveLancarExcecaoComIdAluguelNegativo(int id_aluguelInvalido)
    {
        //Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios(); 

        //Act e Assert
        Assert.Throws<ArgumentException>(() => manutencaoEsperada.ComIdAluguel(id_aluguelInvalido));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    public void DeveLancarExcecaoComIdNegativo(int idInvalido)
    {
        //Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios(); 

        //Act e Assert
        Assert.Throws<ArgumentException>(() => manutencaoEsperada.ComId(idInvalido));
    }

    [Theory]
    [InlineData("1234")]
    [InlineData("123456789012345678901234567890123456789012345678901")]
    public void DeveLancarExcecaoComMotivoComMenosDe5OuMaisDe50Caracteres(string motivoInvalido)
    {
        //Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios(); 

        //Act e Assert
        Assert.Throws<ArgumentException>(() => manutencaoEsperada.ComMotivo(motivoInvalido));
    }

    /* --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */
    //Testes referente as entidades propiamente ditas

    [Fact]
    public void DeveCriarManutencaoEntidade()
    {
        //Arrange 
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios().Build();

        //Act
        Manutencao manutencao = new Manutencao(manutencaoEsperada.Id, manutencaoEsperada.Id_Aluguel, manutencaoEsperada.Motivo, manutencaoEsperada.Valor);

        //Assert
        manutencaoEsperada.ToExpectedObject().ShouldMatch(manutencao);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarManutencaoEntidadeComMotivoNuloEVazio(string motivoInvalido)
    {
        // Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Manutencao(manutencaoEsperada.Id, manutencaoEsperada.Id_Aluguel, motivoInvalido, manutencaoEsperada.Valor));
    }

    [Theory]
    [InlineData(-1150.37)]
    [InlineData(-21150.37)]
    [InlineData(-9.373)]
    public void DeveLancarExececaoAoCriarManutencaoEntidadeComValorNegativo(decimal valorInvalido)
    {
        // Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Manutencao(manutencaoEsperada.Id, manutencaoEsperada.Id_Aluguel, manutencaoEsperada.Motivo, valorInvalido));
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    public void DeveLancarExececaoAoCriarManutencaoEntidadeComIdAluguelNegativo(int id_aluguelInvalido)
    {
        // Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Manutencao(manutencaoEsperada.Id, id_aluguelInvalido, manutencaoEsperada.Motivo, manutencaoEsperada.Valor));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    public void DeveLancarExececaoAoCriarManutencaoEntidadeComIdNegativo(int idInvalido)
    {
        // Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Manutencao(idInvalido, manutencaoEsperada.Id_Aluguel, manutencaoEsperada.Motivo, manutencaoEsperada.Valor));
    }

    [Theory]
    [InlineData("1234")]
    [InlineData("123456789012345678901234567890123456789012345678901")]
    public void DeveLancarExececaoAoCriarManutencaoEntidadeComMotivoComMenosDe5OuMaisDe50Caracteres(string motivoInvalido)
    {
        // Arrange
        var manutencaoEsperada = ManutencaoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Manutencao(manutencaoEsperada.Id, manutencaoEsperada.Id_Aluguel, motivoInvalido, manutencaoEsperada.Valor));
    }


    


}
