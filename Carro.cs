public class Carro : Veiculo
{
    private int numeroDePortas;
    public void abrirPortaMalas()
    {
        Console.WriteLine("Porta mala está aberto!");
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}\n Modelo do carro: {modelo}\n Número de portas: {numeroDePortas}");
    }

    public Carro(string marca, string modelo, int ano, int numeroDePortas) : base(marca, modelo, ano)
    {
        this.numeroDePortas = numeroDePortas;
    }
}