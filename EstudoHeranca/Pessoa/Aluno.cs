using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace EstudoHeranca.Pessoa;

public class Aluno
{
    //properts get; set;
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string Cpf { get; set; }
    public string RA { get; set; }
    public string sexo { get; set; } 
    public int idade { get; set; } 
    public string Situacao { get; set; }
    
    public void ConsultarAluno()
    {
        Aluno aluno = new Aluno();
        
        Console.Write("Informe seu nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Informe seu email: ");
        aluno.Email = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Informe sua idade: ");
        aluno.idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Informe sua situacao (A)provado ou (R)eprovado: ");
        aluno.Situacao = Console.ReadLine();

        Console.Clear();
        
        Curso cursor = new Curso();
        
        cursor.ResultadoAluno(aluno);
    }
    
}
public class Curso
{
    public void ResultadoAluno(Aluno aluno)
    {
       if (aluno.Situacao == "A")
       {
           Console.WriteLine($"O aluno {aluno.Nome} tem {aluno.idade} anos. \n e sua situação é {aluno.Situacao}: Approvado.");
       }
       else //teste
       {
           Console.WriteLine($"O aluno {aluno.Nome} tem {aluno.idade} anos. \n e sua situação é {aluno.Situacao}: Reprovado.");
       }
        
    }
}


