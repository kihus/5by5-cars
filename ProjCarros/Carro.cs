namespace ProjCarros;

internal class Carro
{
    public int Id { get; private set; }
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public int Ano { get; private set; }
    public string Cor { get; private set; }
    public string Placa { get; private set; }

    public Carro(
        int id,
        string marca,
        string modelo,
        int ano,
        string cor,
        string placa
        )
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
        Placa = placa;
    }

    public string ToFile()
    {
        return $"{Id},{Marca},{Modelo},{Ano},{Cor},{Placa}";
    }

    public override string ToString()
    {
        return $"Id: {Id}\n\r" +
            $"Marca: {Marca}\n\r" +
            $"Modelo: {Modelo}\n\r" +
            $"Ano: {Ano}\n\r" +
            $"Cor: {Cor}\n\r" +
            $"Placa: {Placa}\n\r";
    }
}
