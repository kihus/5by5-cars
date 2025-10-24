namespace ProjCarros;

internal class Locadora(List<Carro> carros)
{
    public List<Carro> Carros { get; } = carros;

    public void CadastrarCarro()
    {
        Console.Write("Informe o ID: ");
        var id = int.Parse(Console.ReadLine()!);

        Console.Write("Informe a marca: ");
        var marca = Console.ReadLine() ?? "";

        Console.Write("Informe o modelo: ");
        var modelo = Console.ReadLine() ?? "";

        Console.Write("Informe o ano: ");
        var ano = int.Parse(Console.ReadLine()!);

        Console.Write("Informe a cor: ");
        var cor = Console.ReadLine() ?? "";

        Console.Write("Informe a placa: ");
        var placa = Console.ReadLine() ?? "";

        Carros.Add(new Carro(id, marca, modelo, ano, cor, placa));
    }
    
    public void ListarCarros()
    {
        if (Carros is null)
            Console.WriteLine("Não have carros");
        else
            Carros.ForEach(x => Console.WriteLine(x));
    }

    private Carro BuscaCarro(int id)
    {
        return Carros.Find(c => c.Id == id);
    }

    public void AtualizarCarro()
    {
        Console.Write("Qual o id do carro: ");
        var id = int.Parse(Console.ReadLine()!);

        var carro = BuscaCarro(id);

        if (carro is null)
        {
            Console.WriteLine("Carro n existe meu parceiro");
            return;
        }

        Console.Write("Qual a nova cor do carro: ");
        var corNova = Console.ReadLine() ?? "";
        carro.SetCor(corNova);

        Console.WriteLine(carro);
    }

    public void RemoverCarro()
    {
        Console.Write("Qual o id do carro: ");
        var id = int.Parse(Console.ReadLine()!);

        var carro = BuscaCarro(id);

        if (carro is null)
        {
            Console.WriteLine("Carro n existe meu parceiro");
            return;
        }

        Carros.Remove(carro);


        decimal a = 1.0m;
        Console.WriteLine($"{a:c}");
    }
}
