string[,] alunos = new string[5, 7];
int aulas, linha, coluna;
string nome;
double notaprova1, notaprova2, notaprova3, notatrabalho;
coluna = 0;
aulas = 0; for (linha = 0; linha <= 5; linha++)
{
    Console.Clear();
    Console.WriteLine("================ Boletim ================");
    Console.WriteLine("Informe o nome do 1º aluno: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o numero de aulas dadas: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o numero de faltas: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da PROVA 1: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da PROVA 2: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da PROVA 3: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota do trabalho: ");
    alunos[linha, coluna++] = Console.ReadLine(); coluna = 0;
    Console.Clear();
}