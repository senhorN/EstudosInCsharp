namespace EstudoHeranca.Automovel;

public class Carro
{
    /* Atributos */ 
    public string Modelo { get; set; }
    public string Montadora { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }
    
#region Métodos    
    
    
    public void Acelerar()
    {
        Console.WriteLine("Ele esta caindo ainda aqui...");
    }
#endregion
}
