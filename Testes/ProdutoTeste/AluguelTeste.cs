using Testes.Builders.AluguelBuilder;
using ExpectedObjects;
using Dominio.Entidades.Aluguel;

namespace Testes.ProdutoTeste.AluguelTeste;

/*
Criteiros de Aceite
0- Id não pode ser negativo 
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

    /* --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */
    //Testes referente as entidades propiamente ditas

    /*
    Criteiros de Aceite
    0- Id não pode ser negativo 
    1- Deve criar um aluguel - Done
    2- Data de devolução não pode ser menor que data de retirada - Done
    3- Valor previsto não pode ser negativo - Done
    4- Valor real não pode ser negativo - Done
    5- Km de devolução não pode ser menor que km de retirada, e não pode ser negativo - Done
    6- Quantidade de litros de devolução não pode ser menor que quantidade de litros de retirada - Done
    */

    [Fact]
    public void DeveCriarAluguelEntidade()
    {
        //Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();

        //Act
        Aluguel aluguel = new Aluguel(aluguelEsperado.Id, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, aluguelEsperado.QtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, aluguelEsperado.KmDevolução,
        aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        aluguelEsperado.ValorPrevisto, aluguelEsperado.ValorReal, aluguelEsperado.Id_Veiculo,
        aluguelEsperado.Id_Cliente);

        //Assert
        aluguelEsperado.ToExpectedObject().ShouldMatch(aluguel);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    [InlineData(-4)]
    public void DeveLancarExcecaoIdNegativo(int idInvalido)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(idInvalido, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, aluguelEsperado.QtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, aluguelEsperado.KmDevolução,
        aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        aluguelEsperado.ValorPrevisto, aluguelEsperado.ValorReal, idInvalido,
        idInvalido));
    }

    [Theory]
    [InlineData(-1150.37)]
    [InlineData(-1000.89)]
    [InlineData(-1.50)]
    [InlineData(-100.37)]
    [InlineData(-1000)]
    public void DeveLancarExcecaoValorPrevistoNegativoEntidade(decimal valorPrevistoInvalido)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(aluguelEsperado.Id, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, aluguelEsperado.QtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, aluguelEsperado.KmDevolução,
        aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        valorPrevistoInvalido, aluguelEsperado.ValorReal, aluguelEsperado.Id_Veiculo,
        aluguelEsperado.Id_Cliente));
    }

    [Theory]
    [InlineData(-1150.37)]
    [InlineData(-1000.89)]
    [InlineData(-1.50)]
    [InlineData(-100.37)]
    [InlineData(-1000)]
    public void DeveLancarExcecaoValorRealNegativoEntidade(decimal valorRealInvalido)
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(aluguelEsperado.Id, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, aluguelEsperado.QtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, aluguelEsperado.KmDevolução,
        aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        aluguelEsperado.ValorPrevisto, valorRealInvalido, aluguelEsperado.Id_Veiculo,
        aluguelEsperado.Id_Cliente));
    }

    [Fact]
    public void DeveLancarExcecaoKmDevolucaoMenorQueKmRetiradaEntidade()
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();
        double kmRetirada = 100;
        double kmDevolucao = 50;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(aluguelEsperado.Id, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, kmRetirada, aluguelEsperado.QtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, kmDevolucao,
        aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        aluguelEsperado.ValorPrevisto, aluguelEsperado.ValorReal, aluguelEsperado.Id_Veiculo,
        aluguelEsperado.Id_Cliente));
    }

    [Fact]
    public void DeveLancarExcecaoDataRetiradaMaiorQueDataDevolucaoEntidade()
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();
        DateOnly dataRetirada = aluguelEsperado.DataDevolução.AddDays(1); // Definir a data de retirada como um dia após a data de devolução

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(aluguelEsperado.Id, dataRetirada,
            aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, aluguelEsperado.QtdLtsRetirada,
            aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, aluguelEsperado.KmDevolução,
            aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
            aluguelEsperado.ValorPrevisto, aluguelEsperado.ValorReal, aluguelEsperado.Id_Veiculo,
            aluguelEsperado.Id_Cliente));
    }

    [Fact]
    public void DeveLancarExcecaoKmDevolucaoNegativoEntidade()
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();
        double kmDevolucao = -1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(aluguelEsperado.Id, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, aluguelEsperado.QtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, kmDevolucao,
        aluguelEsperado.QtdLtsDevolução, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        aluguelEsperado.ValorPrevisto, aluguelEsperado.ValorReal, aluguelEsperado.Id_Veiculo,
        aluguelEsperado.Id_Cliente));
    }

    [Fact]
    public void DeveLancarExcecaoQtdLtsDevolucaoMenorQueQtdLtsRetiradaEntidade()
    {
        // Arrange
        var aluguelEsperado = AluguelBuilder.Novo().ComValoresAleatorios().Build();
        double qtdLtsRetirada = 100;
        double qtdLtsDevolucao = 50;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Aluguel(aluguelEsperado.Id, aluguelEsperado.DataRetirada,
        aluguelEsperado.HoraRetirada, aluguelEsperado.KmRetirada, qtdLtsRetirada,
        aluguelEsperado.DataDevolução, aluguelEsperado.HoraDevolução, aluguelEsperado.KmDevolução,
        qtdLtsDevolucao, aluguelEsperado.DataPrevista, aluguelEsperado.HoraPrevista,
        aluguelEsperado.ValorPrevisto, aluguelEsperado.ValorReal, aluguelEsperado.Id_Veiculo,
        aluguelEsperado.Id_Cliente));
    }
}