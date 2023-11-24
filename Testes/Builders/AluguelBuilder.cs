using Bogus;
using Dominio.Entidades.Aluguel;
using Dominio.Entidades.Cliente;
using Dominio.Entidades.Veiculo;
using Testes.Builders.VeiculoBuilder;

namespace Testes.Builders.AluguelBuilder;

public class AluguelBuilder
{
    //propiedades
    private int _id = 1;
    private DateOnly _dataRetirada = new DateOnly(2021, 10, 10);
    private TimeOnly _horaRetirada = new TimeOnly(10, 10, 10);
    private double _kmRetirada = 0;
    private double _qtdLtsRetirada = 55;
    private DateOnly _dataDevolução = new DateOnly(2021, 10, 12);
    private TimeOnly _horaDevolução = new TimeOnly(08, 00, 00);
    private double _kmDevolução = 1500;
    private double _qtdLtsDevolução = 55;
    private DateOnly _dataPrevista = new DateOnly(2021, 10, 12);
    private TimeOnly _horaPrevista = new TimeOnly(08, 00, 00);
    private decimal _valorPrevisto = 1500;
    private decimal _valorReal = 1500;
    private int _id_Veiculo = 1;
    private int _id_Cliente = 1;

    public static AluguelBuilder Novo()
    {
        return new AluguelBuilder();
    }

    public Aluguel Build()
    {
        return new Aluguel(_id, _dataRetirada, _horaRetirada, _kmRetirada, _qtdLtsRetirada, _dataDevolução, _horaDevolução, _kmDevolução, _qtdLtsDevolução, _dataPrevista, _horaPrevista, _valorPrevisto, _valorReal, _id_Veiculo, _id_Cliente);
    }

    public AluguelBuilder ComId(int id)
    {
        _id = id;
        return this;
    }

    public AluguelBuilder ComDataRetirada(DateOnly dataRetirada)
    {
        if (dataRetirada == DateOnly.MinValue)
        {
            throw new ArgumentException("A data de retirada não pode ser nula ou vazia.", nameof(dataRetirada));
        }

        _dataRetirada = dataRetirada;
        return this;
    }


    public AluguelBuilder ComHoraRetirada(TimeOnly horaRetirada)
    {
        _horaRetirada = horaRetirada;
        return this;
    }

    public AluguelBuilder ComKmRetirada(double kmRetirada)
    {
        _kmRetirada = kmRetirada;
        return this;
    }

    public AluguelBuilder ComQtdLtsRetirada(double qtdLtsRetirada)
    {
        _qtdLtsRetirada = qtdLtsRetirada;
        return this;
    }

    public AluguelBuilder ComDataDevolução(DateOnly dataDevolução)
    {
        _dataDevolução = dataDevolução;
        return this;
    }

    public AluguelBuilder ComHoraDevolução(TimeOnly horaDevolução)
    {
        _horaDevolução = horaDevolução;
        return this;
    }

    public AluguelBuilder ComKmDevolução(double kmDevolução)
    {
        if(kmDevolução < _kmRetirada)
            throw new ArgumentException("A quilometragem de devolução não pode ser menor que a quilometragem de retirada.", nameof(kmDevolução));
        _kmDevolução = kmDevolução;
        return this;
    }

    public AluguelBuilder ComQtdLtsDevolução(double qtdLtsDevolução)
    {
        if(qtdLtsDevolução < _qtdLtsRetirada)
            throw new ArgumentException("A quantidade de litros de devolução não pode ser menor que a quantidade de litros de retirada.", nameof(qtdLtsDevolução));
        _qtdLtsDevolução = qtdLtsDevolução;
        return this;
    }

    public AluguelBuilder ComDataPrevista(DateOnly dataPrevista)
    {
        _dataPrevista = dataPrevista;
        return this;
    }

    public AluguelBuilder ComHoraPrevista(TimeOnly horaPrevista)
    {
        _horaPrevista = horaPrevista;
        return this;
    }

    public AluguelBuilder ComValorPrevisto(decimal valorPrevisto)
    {
        if(valorPrevisto < 0)
            throw new ArgumentException("O valor previsto não pode ser negativo.", nameof(valorPrevisto));
        _valorPrevisto = valorPrevisto;
        return this;
    }

    public AluguelBuilder ComValorReal(decimal valorReal)
    {
        if(valorReal < 0)
            throw new ArgumentException("O valor real não pode ser negativo.", nameof(valorReal));
        _valorReal = valorReal;
        return this;
    }

    public AluguelBuilder ComIdVeiculo(int id_Veiculo)
    {
        _id_Veiculo = id_Veiculo;
        return this;
    }

    public AluguelBuilder ComIdCliente(int id_Cliente)
    {
        _id_Cliente = id_Cliente;
        return this;
    }

    public AluguelBuilder ComValoresPadroes()
    {
        _id = 1;
        _dataRetirada = new DateOnly(2021, 10, 10);
        _horaRetirada = new TimeOnly(10, 10, 10);
        _kmRetirada = 0;
        _qtdLtsRetirada = 55;
        _dataDevolução = new DateOnly(2021, 10, 12);
        _horaDevolução = new TimeOnly(08, 00, 00);
        _kmDevolução = 1500;
        _qtdLtsDevolução = 55;
        _dataPrevista = new DateOnly(2021, 10, 12);
        _horaPrevista = new TimeOnly(08, 00, 00);
        _valorPrevisto = 1500;
        _valorReal = 1500;
        _id_Veiculo = 1;
        _id_Cliente = 1;
        return this;
    }

    public AluguelBuilder ComValoresAleatorios()
    {
        Faker faker = new Faker();

        _id = faker.Random.Int(1, 100);
        _dataRetirada = new DateOnly(2021, 10, 10);
        _horaRetirada = new TimeOnly(10, 10, 10);
        _kmRetirada = 0;
        _qtdLtsRetirada = 55;
        _dataDevolução = new DateOnly(2021, 10, 12);
        _horaDevolução = new TimeOnly(08, 00, 00);
        _kmDevolução = 1500;
        _qtdLtsDevolução = 55;
        _dataPrevista = new DateOnly(2021, 10, 12);
        _horaPrevista = new TimeOnly(08, 00, 00);
        _valorPrevisto = 1500;
        _valorReal = 1500;
        _id_Veiculo = 1;
        _id_Cliente = 1;

        return this;
    }
}

