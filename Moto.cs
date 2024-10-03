public class Moto : Veiculo
{
    private bool temBagageiro;
    public void darGrau()
    {
        Console.WriteLine("Randandan! Pá Pá");
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno: {ano}\nTem bagageiro: {temBagageiro}");
    }

    public Moto(string marca, string modelo, int ano) : base(marca, modelo, ano)
    {
        this.temBagageiro = false;
    }

}