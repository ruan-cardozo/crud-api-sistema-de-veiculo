namespace Dominio.Entidades.Manutencao;

public class Manutencao
{
    private int id;
    private int id_aluguel;
    private string? motivo;
    private decimal? valor;

    public int Id { get => id; private set => id = value; }
    public int Id_Aluguel { get => id_aluguel; private set => id_aluguel = value; }
    public string? Motivo { get=> motivo; private set => motivo = value; }
    public decimal? Valor { get=> valor; private set => valor = value; }

    public Manutencao(int id, int id_aluguel, string? motivo, decimal? valor)
    {
        this.id = id;
        this.id_aluguel = id_aluguel;
        this.motivo = motivo;
        this.valor = valor;
    }
}