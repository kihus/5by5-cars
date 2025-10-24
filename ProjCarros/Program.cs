using ProjCarros;

string CarregarPrograma()
{

    string diretorio = @"C:\Arquivos\Locadora";
    if (!Directory.Exists(diretorio))
        Directory.CreateDirectory(diretorio);

    string arquivo = "carros.db";
    var diretorioCompleto = Path.Combine(diretorio, arquivo);

    if (!File.Exists(diretorioCompleto))
    {
        using (StreamWriter sw = File.CreateText(diretorioCompleto))
        {
            sw.Write("Arquivos criado");
            Console.WriteLine("Arquivo criado com sucesso");
            Console.ReadKey();
        }
    }

    return diretorioCompleto;
}

List<Carro> LerArquivo()
{
    var caminho = CarregarPrograma();

    StreamReader reader = new(caminho);
    using (reader)
    {
        List<Carro> carros = new();

        while (reader.Peek() >= 0)
        {
        
            var linha = reader.ReadLine();
            var valores = linha.Split(',');

            Carro carro = new(
              int.Parse(valores[0]),
              valores[1],
              valores[2],
              int.Parse(valores[3]),
              valores[4],
              valores[5]
              );

            carros.Add(carro);
        }
        reader.Close();
        return carros;
    }
}

void GravarArquivo(List<Carro> carros)
{
    var caminho = CarregarPrograma();

    StreamWriter writer = new(caminho);
    using (writer)
    {
        foreach (var carro in carros)
        {
            writer.WriteLine(carro.ToFile());
        }
            writer.Close();
    }
}

var locadora = new Locadora(LerArquivo());

locadora.ListarCarros();

locadora.CadastrarCarro();
locadora.CadastrarCarro();


locadora.ListarCarros();

locadora.AtualizarCarro();

locadora.RemoverCarro();

locadora.ListarCarros();

GravarArquivo(locadora.Carros);