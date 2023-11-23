using Bogus;
using Dominio.Entidades.Cliente;

namespace Testes.Builders.ClienteBuilder;

public class ClienteBuilder
{
    //propiedades
    private int _id = 1;
    private string _nome = "João";
    private string _rg = "412373993";
    private string _cpf = "06419818052";
    private string _cnh = "95716909072";
    private string _telefone = "47939192127";

    public static ClienteBuilder Novo()
    {
        return new ClienteBuilder();
    }

    public Cliente Build()
    {
        return new Cliente(_id, _nome, _rg, _cpf, _telefone, _cnh);
    }

    public ClienteBuilder ComId(int id)
    {   
        if(id <= 0)
            throw new ArgumentException("Id não pode ser negativo");
        _id = id;
        return this;
    }

    public ClienteBuilder ComNome(string nome)
    {
        _nome = nome;
        return this;
    }

    public ClienteBuilder ComRg(string rg)
    {
        _rg = rg;
        return this;
    }

    public ClienteBuilder ComCpf(string cpf)
    {
        _cpf = cpf;
        return this;
    }

    public ClienteBuilder ComTelefone(string telefone)
    {
        _telefone = telefone;
        return this;
    }

    public ClienteBuilder ComCnh(string cnh)
    {
        _cnh = cnh;
        return this;
    }

    public ClienteBuilder ComValoresPadroes()
    {
        _id = 1;
        _nome = "João";
        _rg = "412373993";
        _cpf = "06419818052";
        _cnh = "95716909072";
        _telefone = "47939192127";
        return this;
    }

    public ClienteBuilder ComValoresAleatorios()
    {
        Faker faker = new Faker();

        _id = faker.Random.Int(1, 100);
        _nome = faker.Person.FullName;
        _rg = faker.Random.String2(9, "0123456789");
        _cpf = faker.Random.String2(11, "0123456789");
        _cnh = faker.Random.String2(11, "0123456789");
        _telefone = faker.Phone.PhoneNumber();
        return this;
    }
}