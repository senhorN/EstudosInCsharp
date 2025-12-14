namespace EstudoHeranca.Pessoa;

public class Funcionario
{
    public string nome { get; set; }
    public string cpf { get; set; }
    public string? telefone { get; set; }
    public string email { get; set; }
    public string idade { get; set; }
    public string cep { get; set; }
    public string celular { get; set; }

#region métodos

public void ApresentacaoFuncionario( string nome, int cpf, string telefone, string email)
{
    if (cpf == null )
    {
        Console.WriteLine("CPF inválido!");
    }
    
    Console.WriteLine($" Funcionário: {nome} \n" +
                      $" Portador do CPF: {cpf} \n" +
                      $" Telefone: {telefone} \n" +
                      $" Email: {email} \n"
                      );
}

public void ExbirData()
{
    Console.WriteLine(DateTime.Now.ToShortDateString());
}




#endregion
}