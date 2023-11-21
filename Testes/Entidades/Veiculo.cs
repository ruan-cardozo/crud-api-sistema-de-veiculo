using Dominio.Enums.ModeloEnum;
using Dominio.Enums.MarcaEnum;
using Xunit.Sdk;

namespace Dominio.Entidades.Veiculo;
public class Veiculo
{
    private string placa;
    private Marca marca;
    private Modelo modelo;
    private int? anoFab;
    private double km;
    private string? numChassi;

    public string Placa { get => placa; private set => placa = value; }
    public Marca Marca { get => marca; private set => marca = value; }
    public Modelo Modelo {get => modelo; private set => modelo = value; }
    public int? AnoFab {get => anoFab; private set => anoFab = value; }
    public double Km {get => km; private set => km = value; }
    public string? NumChassi {get => numChassi; private set => numChassi = value; }
    
    public Veiculo(string placa, Marca marca, Modelo modelo, int? anoFab, double km, string numChassi)
    {
        //defina regras para os valores das variaveis
        if (km < 0)
            throw new ArgumentException("Km não pode ser menor que 0", nameof(km));

        if (placa.Length != 7)
            throw new ArgumentException("Placa deve conter 7 caracteres", nameof(placa));

        if (numChassi.Length != 11)
            throw new ArgumentException("Número do chassi deve conter 11 caracteres", nameof(numChassi));

        if (anoFab < 1900)
            throw new ArgumentException("Ano de fabricação não pode ser menor que 1900", nameof(anoFab));    

        if (string.IsNullOrEmpty(placa))
            throw new ArgumentException("Placa não pode ser nula ou vazia", nameof(placa));

        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.anoFab = anoFab;
        this.km = km;
        this.numChassi = numChassi;
    }
}