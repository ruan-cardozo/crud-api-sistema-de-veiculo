namespace Dominio.Entidades.Manutencao;

public class Manutencao
{
    private int id;
    private int id_aluguel;
    private string motivo;
    private decimal valor;

    public int Id { get => id; private set => id = value; }
    public int Id_Aluguel { get => id_aluguel; private set => id_aluguel = value; }
    public string Motivo { get=> motivo; private set => motivo = value; }
    public decimal Valor { get=> valor; private set => valor = value; }

    public Manutencao(int id, int id_aluguel, string motivo, decimal valor)
    {

        if(string.IsNullOrEmpty(motivo)){
            throw new ArgumentException("Motivo da manutenção não pode ser Nulo ou Vazio");
        }
        

        this.Id = id;
        this.Id_Aluguel = id_aluguel;
        this.Motivo = motivo;
        this.Valor = valor;
    }
}