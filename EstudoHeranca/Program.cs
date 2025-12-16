using EstudoHeranca.Automovel;
using EstudoHeranca.Pessoa;

Aluno aluno = new Aluno();

Console.WriteLine("teste");
// aluno.ConsultarAluno();
Carro chevrolet = new Carro(
    "Astra",
    "General Motors",
    "Chevrolet",
    2006,
    260
);

Carro ford = new Carro(
    "Ford",
    "Sanders Motor Sport",
    "Ford",
    2015,
    280
);

/*chevrolet.Modelo = "Astra";
chevrolet.Montadora = "General Motors";
chevrolet.Marca = "Chevrolet";
chevrolet.Ano = 2006;
chevrolet.Potencia = 260;


ford.Modelo = "Ford";
ford.Montadora = "Sanders Motor Sport";
ford.Marca = "Ford";
ford.Ano = 2015;
ford.Potencia = 280;*/

Console.WriteLine($"Eu tenho um {chevrolet.Modelo} modelo {chevrolet.Ano}. Fabricado em {chevrolet.Ano} pela \n" +
                  $"{chevrolet.Marca}. Onde ele tem a potência maxima de {chevrolet.Potencia}");