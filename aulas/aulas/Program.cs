string[,] alunos = new string[6, 6];
int linha, coluna;
string nome;
double notaprova1, notaprova2, notaprova3, notatrabalho;
coluna = 0;

for (linha = 0; linha <= 4; linha++)
{
    Console.Clear();
    Console.WriteLine(" ======= Boletim ======= ");
    Console.WriteLine("informe o nome do primeiro aluno:");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine()


}