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
        if(id < 0)
            throw new ArgumentException("Id não pode ser negativo");

        if(string.IsNullOrEmpty(nome))
            throw new ArgumentException("Nome não pode ser nulo ou vazio");

        if(string.IsNullOrEmpty(rg))
            throw new ArgumentException("RG não pode ser nulo ou vazio");

        if(rg.Length != 9)
            throw new ArgumentException("RG deve conter 9 caracteres");
        
        if(string.IsNullOrEmpty(cpf))
            throw new ArgumentException("CPF não pode ser nulo ou vazio");
        
        if(cpf.Length != 11)
            throw new ArgumentException("CPF deve conter 11 caracteres");
        
        if(string.IsNullOrEmpty(telefone))
            throw new ArgumentException("Telefone não pode ser nulo ou vazio");
        
        if(telefone.Length != 11 && telefone.Length != 10)
            throw new ArgumentException("Telefone deve conter 11 ou 10 caracteres");
        
        if(string.IsNullOrEmpty(cnh))
            throw new ArgumentException("CNH não pode ser nulo ou vazio");
        
        if(cnh.Length != 11)
            throw new ArgumentException("CNH deve conter 11 caracteres");   
        
        this.Id = id;
        this.Nome = nome;
        this.Rg = rg;
        this.Cpf = cpf;
        this.Telefone = telefone;
        this.Cnh = cnh;
    }
}