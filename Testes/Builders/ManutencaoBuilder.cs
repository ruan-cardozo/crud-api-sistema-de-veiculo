using Dominio.Entidades.Manutencao;
using Bogus;

namespace Testes.Builders.ManutencaoBuilder;

public class ManutencaoBuilder
{
    //propiedades
    private int _id = 1;
    private int _id_aluguel = 1;
    private string _motivo = "Troca de oleo";
    private decimal _valor = 100;

    public static ManutencaoBuilder Novo()
    {
        return new ManutencaoBuilder();
    }

    public Manutencao Build()
    {
        return new Manutencao(_id, _id_aluguel, _motivo, _valor);
    }

    public ManutencaoBuilder ComId(int id)
    {
        if(id < 0) 
            throw new ArgumentException("Id da manutenção não pode ser menor que 0");  
        _id = id;
        return this;
    }

    public ManutencaoBuilder ComIdAluguel(int id_aluguel)
    {
        if(id_aluguel <= 0)
            throw new ArgumentException("Id do aluguel não pode ser menor ou igual a 0");
        _id_aluguel = id_aluguel;
        return this;
    }

    public ManutencaoBuilder ComMotivo(string motivo)
    {
        if(string.IsNullOrEmpty(motivo))
            throw new ArgumentException("Motivo da manutenção não pode ser Nulo ou Vazio");
        if(motivo.Length < 5 || motivo.Length > 50)
            throw new ArgumentException("Motivo deve ter entre 5 e 50 caracteres");
            
        _motivo = motivo;
        return this;
    }

    public ManutencaoBuilder ComValor(decimal valor)
    {
        if(valor <= 0 )
            throw new ArgumentException("Valor da manutenção não pode ser menor ou igual a 0");
        
        _valor = valor;
        return this;
    }

    public ManutencaoBuilder ComValoresPadroes()
    {
        _id = 1;
        _id_aluguel = 1;
        _motivo = "Troca de oleo";
        _valor = 100;
        return this;
    }

    public ManutencaoBuilder ComValoresAleatorios()
    {
        Faker faker = new Faker();

        _id = faker.Random.Int(1, 100);
        _id_aluguel = faker.Random.Int(1, 100);
        _motivo = faker.Random.String2(10, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        _valor = faker.Random.Decimal(1, 1000);

        return this;
    }
}