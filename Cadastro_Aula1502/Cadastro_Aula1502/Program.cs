string [,] cadastro_papelaria = new string[4, 5];
int linha = 0;
int coluna = 0;
string pesquisar = "";




for (linha = 0; linha <= 5; linha++)
{
    Console.WriteLine("Informe a DESCRIÇÃO do produto:");
   cadastro_papelaria [linha, coluna++] = Console.ReadLine();
    
    coluna = 0;
}

Console.WriteLine("1 - Pesquisar produtos | 2 - Retornar ao menu ");

switch (pesquisar);

    case 1:

    pesquisar = "S";
