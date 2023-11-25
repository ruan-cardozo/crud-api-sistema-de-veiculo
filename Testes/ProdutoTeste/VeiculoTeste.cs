using Testes.Builders.VeiculoBuilder;
using ExpectedObjects;
using Dominio.Entidades.Veiculo;

//Criterios de aceite
/*
1. Placa nao pode ser nula nem vazia - Done
2. Placa deve conter 7 caracteres - Done
3. anoFab não pode execeder 1900 - Done
4. km não pode ser menor que 0 - Done
5. numChassi não pode ser nulo nem vazio - Done
6. numChassi deve conter 11 caracteres - Done
7. Marca não pode ser nula nem vazia - Done
8. Modelo pode ser nulo ou vazio - Done 
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

    [Theory]
    [InlineData("5910031615")]
    [InlineData("591003161581")]
    [InlineData("591")]
    [InlineData("5910031615812")]
    public void NumChassiNaoDeveAceitarValoresDiferentesDe11Caracteres(string numChassi)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComNumChassi(numChassi));
    }


    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoComMarcaNulaEVazia(string marca)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComMarca(marca));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoComModeloNuloEVazio(string modelo)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => veiculoEsperado.ComModelo(modelo));
    }

    /* --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */
    //Testes referente as entidades propiamente ditas

    [Fact]
    public void DeveCriarVeiculoEntidade()
    {
        //Arrange 
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();    
        
        //Act
        Veiculo veiculo = new Veiculo(veiculoEsperado.Placa, veiculoEsperado.Marca, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, veiculoEsperado.Km, veiculoEsperado.NumChassi);
        //Assert
        veiculoEsperado.ToExpectedObject().ShouldMatch(veiculo);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoEntidadeComPlacaNulaEVazia(string placaInvalida)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(placaInvalida, veiculoEsperado.Marca, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, veiculoEsperado.Km, veiculoEsperado.NumChassi));
    }

    [Theory]
    [InlineData("HPSAD046")]
    [InlineData("HPS-04656")]
    [InlineData("HPS-0465-")]
    [InlineData("HPS-0465-1")]
    [InlineData("HPS-0465-12")]
    [InlineData("HPS-0465-123")]
    public void PlacaNaoDeveAceitarValoresDiferentesDe7CaracteresEntidade(string placaInvalida)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(placaInvalida, veiculoEsperado.Marca, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, veiculoEsperado.Km, veiculoEsperado.NumChassi));
    }

    [Theory]
    [InlineData(1899)]
    public void DeveLancarExececaoAoCriarVeiculoEntidadeComAnoFabMenorQue1900(int anoFabInvalido)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(veiculoEsperado.Placa, veiculoEsperado.Marca, veiculoEsperado.Modelo, anoFabInvalido, veiculoEsperado.Km, veiculoEsperado.NumChassi));
    }

    [Theory]
    [InlineData(-1.15)]
    [InlineData(-150.25)]
    [InlineData(-0.5)]
    [InlineData(-0.0001)]
    public void DeveLancarExececaoAoCriarVeiculoEntidadeComKmNegativo(double kmInvalido)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(veiculoEsperado.Placa, veiculoEsperado.Marca, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, kmInvalido, veiculoEsperado.NumChassi));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoEntidadeComNumChassiNulaEVazia(string numChassiInvalido)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(veiculoEsperado.Placa, veiculoEsperado.Marca, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, veiculoEsperado.Km, numChassiInvalido));
    }

    [Theory]
    [InlineData("5910031615")]
    [InlineData("591003161581")]
    [InlineData("591")]
    [InlineData("5910031615812")]
    public void NumChassiNaoDeveAceitarValoresDiferentesDe11CaracteresEntidade(string numChassiInvalido)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(veiculoEsperado.Placa, veiculoEsperado.Marca, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, veiculoEsperado.Km, numChassiInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoEntidadeComMarcaNulaEVazia(string marcaInvalida)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(veiculoEsperado.Placa, marcaInvalida, veiculoEsperado.Modelo, veiculoEsperado.AnoFab, veiculoEsperado.Km, veiculoEsperado.NumChassi));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExececaoAoCriarVeiculoEntidadeComModeloNuloEVazio(string modeloInvalido)
    {
        // Arrange
        var veiculoEsperado = VeiculoBuilder.Novo().ComValoresAleatorios().Build();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Veiculo(veiculoEsperado.Placa, veiculoEsperado.Marca, modeloInvalido, veiculoEsperado.AnoFab, veiculoEsperado.Km, veiculoEsperado.NumChassi));
    }

    
}