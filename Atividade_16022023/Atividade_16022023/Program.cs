string[,] pessoas = new string[5,3];
int linha;
int coluna = 0;


for (linha = 0; linha <= 4; linha++)
{
    Console.WriteLine("Informe o nome do usuario:");
    pessoas [linha, coluna++] = Console.ReadLine();

    Console.WriteLine("Informe o Sobrenome do usuario:");
    pessoas[linha, coluna++] = Console.ReadLine();

    Console.WriteLine("Informe o ano de nascimento:");
    pessoas[linha, coluna++] = Console.ReadLine();

 
    coluna = 0;
}




