using Bogus;
using Domain.Enums.ModeloEnum;
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
}