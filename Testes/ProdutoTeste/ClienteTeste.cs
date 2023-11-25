using Testes.Builders.ClienteBuilder;
using Dominio.Entidades.Cliente;
using ExpectedObjects;

/*Criterios de Aceite 
0- Id não pode ser negativo - Done
1- Deve criar um cliente - Done
2- Nome não pode ser nulo ou vazio - Done
3- CPF não pode ser nulo ou vazio - Done
4- CPF deve conter 11 caracteres - Done
5- CNH não pode ser nulo ou vazio - Done
6- CNH deve conter 11 caracteres - Done
7- RG deve conter 9 caracteres - Done
8- Telefone deve conter 11 ou 10 caracteres - Done
9- Telefone não pode ser nulo ou vazio - Done
10- RG não pode ser nulo ou vazio - Done
*/

namespace Testes.ProdutoTeste.ClienteTeste;

public class ClienteTeste
{
    [Fact]
    public void DeveCriarCliente()
    {
        //Arrange
        var clienteEsperado = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act
        var cliente = ClienteBuilder.Novo().ComValoresAleatorios();

        //Assert
        clienteEsperado.ToExpectedObject().ShouldMatch(cliente);
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-4)]
    [InlineData(0)]
    public void DeveLancarExececaoAoCriarClienteComIDNegativo(int idInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        ///Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComId(idInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriarClienteComNomeVazioOuNulo(string nomeInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComNome(nomeInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriarClienteComCpfVazioOuNulo(string cpfInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComCpf(cpfInvalido));
    }

    [Theory]
    [InlineData("1234")]
    [InlineData("0123456789")]
    [InlineData("1234567891011")]
    [InlineData("123456789101112")]
    [InlineData("12345678910111213")]
    public void DeveLancarExecaoAoCriarClienteComCpfComTamanhoInvalido(string cpfInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComCpf(cpfInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriarClienteComCnhVazioOuNulo(string cnhInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComCnh(cnhInvalido));
    }

    [Theory]
    [InlineData("1234")]
    [InlineData("0123456789")]
    [InlineData("1234567891011")]
    [InlineData("123456789101112")]
    [InlineData("12345678910111213")]
    public void DeveLancarExecaoAoCriarClienteComCnhComTamanhoInvalido(string cnhInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComCnh(cnhInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriaClienteComRgVazioOuNulo(string rgInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComRg(rgInvalido));
    }

    [Theory]
    [InlineData("1234567")]
    [InlineData("12345678")]
    [InlineData("123456")]
    [InlineData("1234")]
    public void DeveLancarExecaoAoCriaClienteComRgComTamanhoInvalido(string rgInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComRg(rgInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriaClienteComTelefoneVazioOuNulo(string telefoneInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComTelefone(telefoneInvalido));
    }

    [Theory]
    [InlineData("123456789")]
    [InlineData("1234")]
    [InlineData("123456789101112")]
    [InlineData("12345678910111213")]
    public void DeveLancarExecaoAoCriaClienteComTelefoneComTamanhoInvalido(string telefoneInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresAleatorios();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => clienteBuilder.ComTelefone(telefoneInvalido));
    }

    /* --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */
    //Testes referente as entidades propiamente ditas

    /* --- Criterios de Aceite ---- */
    /*
    0- Id não pode ser negativo - Done
    1- Deve criar um cliente - Done
    2- Nome não pode ser nulo ou vazio - Done
    3- CPF não pode ser nulo ou vazio - Done
    4- CPF deve conter 11 caracteres - Done
    5- CNH não pode ser nulo ou vazio - Done
    6- CNH deve conter 11 caracteres - Done
    7- RG deve conter 9 caracteres - Done
    8- Telefone deve conter 11 ou 10 caracteres - Done
    9- Telefone não pode ser nulo ou vazio - Done
    10- RG não pode ser nulo ou vazio - Done
    */

    [Fact]
    public void DeveCriarClienteEntidade()
    {
        //Arrange
        var clienteEsperado = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act
        Cliente cliente = new Cliente(clienteEsperado.Id, clienteEsperado.Nome, clienteEsperado.Rg, clienteEsperado.Cpf, clienteEsperado.Telefone, clienteEsperado.Cnh);

        //Assert
        clienteEsperado.ToExpectedObject().ShouldMatch(cliente);
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-4)]
    public void DeveLancarExececaoAoCriarClienteEntidadeComIDNegativo(int idInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        ///Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(idInvalido, clienteBuilder.Nome, clienteBuilder.Rg, clienteBuilder.Cpf, clienteBuilder.Telefone, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriarClienteEntidadeComNomeVazioOuNulo(string nomeInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, nomeInvalido, clienteBuilder.Rg, clienteBuilder.Cpf, clienteBuilder.Telefone, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriarClienteEntidadeComCpfVazioOuNulo(string cpfInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, clienteBuilder.Rg, cpfInvalido, clienteBuilder.Telefone, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData("1234")]
    [InlineData("0123456789")]
    [InlineData("1234567891011")]
    [InlineData("123456789101112")]
    [InlineData("12345678910111213")]
    public void DeveLancarExecaoAoCriarClienteEntidadeComCpfComTamanhoInvalido(string cpfInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, clienteBuilder.Rg, cpfInvalido, clienteBuilder.Telefone, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriarClienteEntidadeComCnhVazioOuNulo(string cnhInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, clienteBuilder.Rg, clienteBuilder.Cpf, clienteBuilder.Telefone, cnhInvalido));
    }

    [Theory]
    [InlineData("1234")]
    [InlineData("0123456789")]
    [InlineData("1234567891011")]
    [InlineData("123456789101112")]
    [InlineData("12345678910111213")]
    public void DeveLancarExecaoAoCriarClienteEntidadeComCnhComTamanhoInvalido(string cnhInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, clienteBuilder.Rg, clienteBuilder.Cpf, clienteBuilder.Telefone, cnhInvalido));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriaClienteEntidadeComRgVazioOuNulo(string rgInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, rgInvalido, clienteBuilder.Cpf, clienteBuilder.Telefone, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData("1234567")]
    [InlineData("12345678")]
    [InlineData("123456")]
    [InlineData("1234")]
    public void DeveLancarExecaoAoCriaClienteEntidadeComRgComTamanhoInvalido(string rgInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, rgInvalido, clienteBuilder.Cpf, clienteBuilder.Telefone, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveLancarExecaoAoCriaClienteEntidadeComTelefoneVazioOuNulo(string telefoneInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, clienteBuilder.Rg, clienteBuilder.Cpf, telefoneInvalido, clienteBuilder.Cnh));
    }

    [Theory]
    [InlineData("123456789")]
    [InlineData("1234")]
    [InlineData("123456789101112")]
    [InlineData("12345678910111213")]
    public void DeveLancarExecaoAoCriaClienteEntidadeComTelefoneComTamanhoInvalido(string telefoneInvalido)
    {
        //Arrange
        var clienteBuilder = ClienteBuilder.Novo().ComValoresPadroes().Build();

        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Cliente(clienteBuilder.Id, clienteBuilder.Nome, clienteBuilder.Rg, clienteBuilder.Cpf, telefoneInvalido, clienteBuilder.Cnh));
    }
   
}