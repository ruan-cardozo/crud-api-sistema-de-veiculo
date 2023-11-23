using Bogus;
using Dominio.Entidades.Veiculo;

namespace Testes.Builders.VeiculoBuilder;

public class VeiculoBuilder
{
    //propiedades
    private string _placa = "HPS-0465";
    private string _marca = "BMW";
    private string _modelo = "X6";
    private int _anoFab = 2023;
    private double _km = 0.5;
    private string _numChassi = "59100316158";

    public static VeiculoBuilder Novo()
    {
        return new VeiculoBuilder();
    }

    public Veiculo Build()
    {
        return new Veiculo(_placa, _marca, _modelo, _anoFab, _km, _numChassi);
    }

    public VeiculoBuilder ComPlaca(string placa)
    {   
        if(string.IsNullOrEmpty(placa))
            throw new ArgumentException("Placa não pode ser nula ou vazia", nameof(placa));
        if(placa.Length != 7)
            throw new ArgumentException("Placa deve conter 7 caracteres", nameof(placa));
        _placa = placa;
        return this;
    }

    public VeiculoBuilder ComMarca(string marca)
    {
        if(string.IsNullOrEmpty(marca))
            throw new ArgumentException("Marca não pode ser nula ou vazio", nameof(marca));
        _marca = marca;
        return this;
    }

    public VeiculoBuilder ComModelo(string modelo)
    {
        if(string.IsNullOrEmpty(modelo))
            throw new ArgumentException("Modelo não pode ser nulo ou vazio", nameof(modelo));
        _modelo = modelo;
        return this;
    }

    public VeiculoBuilder ComAnoFab(int anoFab)
    {
        if(anoFab < 1900)
            throw new ArgumentException("Ano de fabricação não pode ser menor que 1900", nameof(anoFab));
        _anoFab = anoFab;
        return this;
    }

    public VeiculoBuilder ComKm(double km)
    {   if(km<0)
            throw new ArgumentException("Km não pode ser menor que 0", nameof(km));
        if(string.IsNullOrEmpty(km.ToString()))
            throw new ArgumentException("Km não pode ser nulo ou vazio", nameof(km));
        _km = km;
        return this;
    }

    public VeiculoBuilder ComNumChassi(string numChassi)
    {
        if(string.IsNullOrEmpty(numChassi))
            throw new ArgumentException("Número do chassi não pode ser nulo ou vazio", nameof(numChassi));
        if (numChassi.Length != 11)
            throw new ArgumentException("Número do chassi deve conter 11 caracteres", nameof(numChassi));    
        _numChassi = numChassi;
        return this;
    }

    public VeiculoBuilder ComValoresPadroes()
    {
        _placa = "HPS-0465";
        _marca = "BMW";
        _modelo = "X6";
        _anoFab = 2023;
        _km = 0.5;
        _numChassi = "59100316158";
        return this;
    }

    public VeiculoBuilder ComValoresAleatorios()
    {
        Faker faker = new Faker();

        _placa = faker.Random.String2(7, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
        _marca = faker.PickRandom(new string[] {"BMW", "Fiat", "Ford", "Honda", "Hyundai", "Mercedes", "Renault", "Toyota", "Volkswagen"});
        _modelo = faker.PickRandom(new string [] {"X6", "Uno", "Ka", "Civic", "HB20", "C180", "Sandero", "Corolla", "Gol"});
        _anoFab = faker.Random.Int(2000, 2021);
        _km = faker.Random.Double(0, 100000);
        _numChassi = faker.Random.String2(11, "0123456789");
        return this;
    }
}