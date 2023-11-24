using Dominio.Enums.ModeloEnum;
using Dominio.Enums.MarcaEnum;
using Xunit.Sdk;

namespace Dominio.Entidades.Veiculo;
public class Veiculo
{
    private string placa;
    private string marca;
    private string modelo;
    private int? anoFab;
    private double km; //menor que 0
    private string? numChassi;

    public string Placa { get => placa; private set => placa = value; }
    public string Marca { get => marca; private set => marca = value; }
    public string Modelo {get => modelo; private set => modelo = value; }
    public int? AnoFab {get => anoFab; private set => anoFab = value; }
    public double Km {get => km; private set => km = value; }
    public string? NumChassi {get => numChassi; private set => numChassi = value; }
    
    public Veiculo(string placa, string marca, string modelo, int? anoFab, double km, string numChassi)
    {
        //defina regras para os valores das variaveis
        if (marca == null)
            throw new ArgumentException("Marca não pode ser nula", nameof(marca));
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

        this.Placa = placa;
        this.Marca = marca;
        this.Modelo = modelo;
        this.AnoFab = anoFab;
        this.Km = km;
        this.NumChassi = numChassi;
    }
}