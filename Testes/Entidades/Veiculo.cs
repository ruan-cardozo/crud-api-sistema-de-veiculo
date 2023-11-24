namespace Dominio.Entidades.Veiculo;
public class Veiculo
{
    private string placa;
    private string marca;
    private string modelo;
    private int anoFab;
    private double km;
    private string numChassi;

    public string Placa { get => placa; private set => placa = value; }
    public string Marca { get => marca; private set => marca = value; }
    public string Modelo { get => modelo; private set => modelo = value; }
    public int AnoFab { get => anoFab; private set => anoFab = value; }
    public double Km { get => km; private set => km = value; }
    public string NumChassi { get => numChassi; private set => numChassi = value; }

    public Veiculo(string placa, string marca, string modelo, int anoFab, double km, string numChassi)
    {
        //defina regras para os valores das variaveis
        if (string.IsNullOrEmpty(modelo))
            throw new ArgumentException("Modelo não pode ser nulo ou vazio", nameof(modelo));
            
        if (string.IsNullOrEmpty(marca))
            throw new ArgumentException("Marca não pode ser nula ou vazio", nameof(marca));
        if (km < 0)
            throw new ArgumentException("Km não pode ser menor que 0", nameof(km));

        if (placa.Length != 7)
            throw new ArgumentException("Placa deve conter 7 caracteres", nameof(placa));

        if (numChassi.Length != 11)
            throw new ArgumentException("Número do chassi deve conter 11 caracteres", nameof(numChassi));

        if (string.IsNullOrEmpty(numChassi))
            throw new ArgumentException("Número do chassi não pode ser nulo ou vazio", nameof(numChassi));

        if (anoFab < 1900)
            throw new ArgumentException("Ano de fabricação não pode ser menor que 1900", nameof(anoFab));

        if (string.IsNullOrEmpty(placa))
            throw new ArgumentException("Placa não pode ser nula ou vazia", nameof(placa));

        if (string.IsNullOrEmpty(km.ToString()))
            throw new ArgumentException("Km não pode ser nulo ou vazio", nameof(km));

        this.Placa = placa;
        this.Marca = marca;
        this.Modelo = modelo;
        this.AnoFab = anoFab;
        this.Km = km;
        this.NumChassi = numChassi;
    }
}