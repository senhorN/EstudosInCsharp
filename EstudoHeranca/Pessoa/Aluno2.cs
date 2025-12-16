using System.Reflection.Metadata;

namespace EstudoHeranca.Pessoa;

public class Aluno2
{
    public Aluno2(int nota) => Nota = nota; 
    
    public Aluno2(string nome, string sexo, string telefone, string situacao, int nota) : this(nota)
    {
        Nome = nome;
        Sexo = sexo;
        Telefone = telefone;
        Situacao = situacao;
        Nota = nota;
    }
    
    
    public string Nome { get; set; }
    public string Sexo { get; set; }
    public string Telefone { get; set; }
    public string Situacao { get; set; }
    public int Nota { get; set; }
}