using Testes.Builders.ClienteBuilder;
using Dominio.Entidades.Cliente;
using ExpectedObjects;

/*Criterios de Aceite 
0- Id não pode ser nulo ou vazio
1- Deve criar um cliente
2- Nome não pode ser nulo ou vazio
3- CPF não pode ser nulo ou vazio
4- CPF deve conter 11 caracteres
5- CNH não pode ser nulo ou vazio
6- CNH deve conter 11 caracteres
7- RG deve conter 9 caracteres
8- Telefone deve conter 11 ou 10 caracteres
9- Telefone não pode ser nulo ou vazio
10- RG não pode ser nulo ou vazio
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

    
}