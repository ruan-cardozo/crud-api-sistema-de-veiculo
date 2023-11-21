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
}