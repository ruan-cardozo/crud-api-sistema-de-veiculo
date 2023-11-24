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
        if(string.IsNullOrEmpty(nome))
            throw new ArgumentException("Nome não pode ser nulo ou vazio");
        _nome = nome;   
        return this;
    }

    public ClienteBuilder ComRg(string rg)
    {   
        if(string.IsNullOrEmpty(rg))
            throw new ArgumentException("RG não pode ser nulo ou vazio");
        if(rg.Length != 9)
            throw new ArgumentException("RG deve conter 9 caracteres");
        _rg = rg;
        return this;
    }

    public ClienteBuilder ComCpf(string cpf)
    {   if(string.IsNullOrEmpty(cpf))
            throw new ArgumentException("CPF não pode ser nulo ou vazio");
        if(cpf.Length != 11)
            throw new ArgumentException("CPF deve conter 11 caracteres");
        _cpf = cpf;
        return this;
    }

    public ClienteBuilder ComTelefone(string telefone)
    {   
        if(string.IsNullOrEmpty(telefone))
            throw new ArgumentException("Telefone não pode ser nulo ou vazio");
        if(telefone.Length != 11 && telefone.Length != 10)
            throw new ArgumentException("Telefone deve conter 11 ou 10 caracteres");
        _telefone = telefone;
        return this;
    }

    public ClienteBuilder ComCnh(string cnh)
    {   if(string.IsNullOrEmpty(cnh))
            throw new ArgumentException("CPF não pode ser nulo ou vazio");
        if(cnh.Length != 11)
            throw new ArgumentException("CPF deve conter 11 caracteres");
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