namespace Dominio.Entidades.Aluguel;

public class Aluguel
{
    private int Id;
    private DateOnly DataRetirada;
    private TimeOnly HoraRetirada;
    private double KmRetirada;
    private double QtdLtsRetirada;
    private DateOnly DataDevolução;
    private TimeOnly HoraDevolução;
    private double KmDevolução;
    private double QtdLtsDevolução;
    private DateOnly DataPrevista;
    private TimeOnly HoraPrevista;
    private decimal ValorPrevisto;
    private decimal ValorReal;
    private int Id_Veiculo;
    private int Id_Cliente;

    public Aluguel(int id, DateOnly dataRetirada, TimeOnly horaRetirada, double kmRetirada, double qtdLtsRetirada, DateOnly dataDevolução, TimeOnly horaDevolução, double kmDevolução, double qtdLtsDevolução, DateOnly dataPrevista, TimeOnly horaPrevista, decimal valorPrevisto, decimal valorReal, int id_Veiculo, int id_Cliente)
    {
        Id = id;
        DataRetirada = dataRetirada;
        HoraRetirada = horaRetirada;
        KmRetirada = kmRetirada;
        QtdLtsRetirada = qtdLtsRetirada;
        DataDevolução = dataDevolução;
        HoraDevolução = horaDevolução;
        KmDevolução = kmDevolução;
        QtdLtsDevolução = qtdLtsDevolução;
        DataPrevista = dataPrevista;
        HoraPrevista = horaPrevista;
        ValorPrevisto = valorPrevisto;
        ValorReal = valorReal;
        Id_Veiculo = id_Veiculo;
        Id_Cliente = id_Cliente;
    }
}