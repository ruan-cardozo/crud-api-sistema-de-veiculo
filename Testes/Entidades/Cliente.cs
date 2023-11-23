namespace Dominio.Entidades.Cliente;

public class Cliente
{
    private int id;
    private string nome;
    private string rg;
    private string cpf;
    private string telefone;
    private string cnh;

    public int Id { get => id; private set => id = value; }
    public string Nome { get => nome; private set => nome = value; }
    public string Rg { get => rg; private set => rg = value; }
    public string Cpf { get => cpf; private set => cpf = value; }
    public string Telefone { get => telefone; private set => telefone = value; }
    public string Cnh { get => cnh; private set => cnh = value; }
    
    public Cliente(int id, string nome, string rg, string cpf, string telefone, string cnh)
    {
        if(id <= 0)
            throw new ArgumentException("Id não pode ser negativo");
        this.id = id;
        this.nome = nome;
        this.rg = rg;
        this.cpf = cpf;
        this.telefone = telefone;
        this.cnh = cnh;
    }
}