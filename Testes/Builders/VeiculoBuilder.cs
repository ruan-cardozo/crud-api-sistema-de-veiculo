using Bogus;
using Dominio.Enums.ModeloEnum;
using Dominio.Entidades.Veiculo;
using Dominio.Enums.MarcaEnum; 

namespace Testes.Builders.VeiculoBuilder;

public class VeiculoBuilder
{
    //propiedades
    private string _placa = "HPS-0465";
    private Marca _marca = Marca.BMW;
    private Modelo _modelo = Modelo.X6;
    private int? _anoFab = 2023;
    private double _km = 0;
    private string? _numChassi = "59100316158";

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
        _placa = placa;
        return this;
    }

    public VeiculoBuilder ComMarca(Marca marca)
    {
        _marca = marca;
        return this;
    }

    public VeiculoBuilder ComModelo(Modelo modelo)
    {
        _modelo = modelo;
        return this;
    }

    public VeiculoBuilder ComAnoFab(int? anoFab)
    {
        _anoFab = anoFab;
        return this;
    }

    public VeiculoBuilder ComKm(double km)
    {
        _km = km;
        return this;
    }

    public VeiculoBuilder ComNumChassi(string? numChassi)
    {
        _numChassi = numChassi;
        return this;
    }

    public VeiculoBuilder ComValoresPadroes()
    {
        _placa = "HPS-0465";
        _marca = Marca.BMW;
        _modelo = Modelo.X6;
        _anoFab = 2023;
        _km = 0;
        _numChassi = "59100316158";
        return this;
    }

    public VeiculoBuilder ComValoresAleatorios()
    {
        var faker = new Faker();

        _placa = faker.Random.String2(7, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
        _marca = faker.PickRandom<Marca>();
        _modelo = faker.PickRandom<Modelo>();
        _anoFab = faker.Random.Int(2000, 2021);
        _km = faker.Random.Double(0, 100000);
        _numChassi = faker.Random.String2(11, "0123456789");
        return this;
    }
}