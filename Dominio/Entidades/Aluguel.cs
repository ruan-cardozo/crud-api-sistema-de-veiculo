namespace Dominio.Entidades.Aluguel;

public class Aluguel
{
    private int id;
    private DateOnly dataRetirada;
    private TimeOnly horaRetirada;
    private double kmRetirada;
    private double qtdLtsRetirada;
    private DateOnly dataDevolução;
    private TimeOnly horaDevolução;
    private double kmDevolução;
    private double qtdLtsDevolução;
    private DateOnly dataPrevista;
    private TimeOnly horaPrevista;
    private decimal valorPrevisto;
    private decimal valorReal;
    private int id_Veiculo;
    private int id_Cliente;

    public int Id { get => id; private set => id = value; }
    public DateOnly DataRetirada { get => dataRetirada; private set => dataRetirada = value; }
    public TimeOnly HoraRetirada { get => horaRetirada; private set => horaRetirada = value; }
    public double KmRetirada { get => kmRetirada; private set => kmRetirada = value; }
    public double QtdLtsRetirada { get => qtdLtsRetirada; private set => qtdLtsRetirada = value; }
    public DateOnly DataDevolução { get => dataDevolução; private set => dataDevolução = value; }
    public TimeOnly HoraDevolução { get => horaDevolução; private set => horaDevolução = value; }
    public double KmDevolução { get => kmDevolução; private set => kmDevolução = value; }
    public double QtdLtsDevolução { get => qtdLtsDevolução; private set => qtdLtsDevolução = value; }
    public DateOnly DataPrevista { get => dataPrevista; private set => dataPrevista = value; }
    public TimeOnly HoraPrevista { get => horaPrevista; private set => horaPrevista = value; }
    public decimal ValorPrevisto { get => valorPrevisto; private set => valorPrevisto = value; }
    public decimal ValorReal { get => valorReal; private set => valorReal = value; }
    public int Id_Veiculo { get => id_Veiculo; private set => id_Veiculo = value; }
    public int Id_Cliente { get => id_Cliente; private set => id_Cliente = value; }



    public Aluguel(int id, DateOnly dataRetirada, TimeOnly horaRetirada, double kmRetirada, double qtdLtsRetirada, DateOnly dataDevolução, TimeOnly horaDevolução, double kmDevolução, double qtdLtsDevolução, DateOnly dataPrevista, TimeOnly horaPrevista, decimal valorPrevisto, decimal valorReal, int id_Veiculo, int id_Cliente)
    {
        if (id < 0)
            throw new ArgumentException("Id não pode ser negativo", nameof(id));

        if (dataRetirada == DateOnly.MinValue)
            throw new ArgumentException("Data de retirada não pode ser nula ou vazia", nameof(dataRetirada));

        if (dataDevolução < dataRetirada)
            throw new ArgumentException("Data de devolução não pode ser menor que data de retirada", nameof(dataDevolução));

        if (kmDevolução < 0 || kmRetirada < 0)
            throw new ArgumentException("Km não pode ser negativo", nameof(kmRetirada));

        if (kmDevolução < kmRetirada)
            throw new ArgumentException("Km de devolução não pode ser menor que km de retirada", nameof(kmDevolução));

        if (qtdLtsDevolução < qtdLtsRetirada)
            throw new ArgumentException("Quantidade de litros de devolução não pode ser menor que quantidade de litros de retirada", nameof(qtdLtsDevolução));

        if (valorPrevisto < 0)
            throw new ArgumentException("Valor previsto não pode ser negativo", nameof(valorPrevisto));

        if (valorReal < 0)
            throw new ArgumentException("Valor real não pode ser negativo", nameof(valorReal));


        this.Id = id;
        this.DataRetirada = dataRetirada;
        this.HoraRetirada = horaRetirada;
        this.KmRetirada = kmRetirada;
        this.QtdLtsRetirada = qtdLtsRetirada;
        this.DataDevolução = dataDevolução;
        this.HoraDevolução = horaDevolução;
        this.KmDevolução = kmDevolução;
        this.QtdLtsDevolução = qtdLtsDevolução;
        this.DataPrevista = dataPrevista;
        this.HoraPrevista = horaPrevista;
        this.ValorPrevisto = valorPrevisto;
        this.ValorReal = valorReal;
        this.Id_Veiculo = id_Veiculo;
        this.Id_Cliente = id_Cliente;
    }
}