using Domain.Enums.ModeloEnum;
using Dominio.Enums.MarcaEnum;

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
        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.anoFab = anoFab;
        this.km = km;
        this.numChassi = numChassi;
    }
}