// Criar Variáveis (Marina)
string[,] produtos = new string[6, 4];
int linha = 0;
int coluna = 0;
int codigo = 0;
string continuar = "S";
string pesquisar = "S";
string busca = "";
double total = 0;
int opcao = 0;

// Cadastrar Produtos
for (linha = 0; linha <= 5; linha++)
{
    Console.WriteLine("Informe a DESCRIÇÃO do produto:");
    produtos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a TIPO do produto:");
    produtos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a COR do produto:");
    produtos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a PREÇO do produto:");
    produtos[linha, coluna++] = Console.ReadLine();

    coluna = 0;
}

Console.WriteLine("1 - COMPRAR  |  2 - PESQUISAR");

switch (opcao)
{
    case 1:
        // -- INICIO
        continuar = "S";
        while (continuar == "S" || continuar == "s")
        {
            Console.Clear();

            // Listar Produtos
            for (linha = 0; linha <= 5; linha++)
            {
                for (coluna = 0; coluna <= 3; coluna++)
                {
                    Console.Write(produtos[linha, coluna] + " - ");
                }
                Console.WriteLine("");
            }

            // Escolher Produtos Listados
            Console.WriteLine("Escolha o produto desejado:");
            codigo = int.Parse(Console.ReadLine());

            // Totalizar a venda
            total = total + double.Parse(produtos[codigo, 3]);
            Console.WriteLine("Subtotal da compra é: " + total);

            Console.WriteLine("Deseja comprar outro produto? S / N");
            continuar = Console.ReadLine();
        }
        // -- FIM
        break;
    case 2:
        pesquisar = "S";
        while (pesquisar == "S" || pesquisar == "s")
        {
            Console.WriteLine("DESCRIÇÃO que deseja buscar?");
            busca = Console.ReadLine();

            for (linha = 0; linha <= 5; linha++)
            {
                if (busca == produtos[linha, 0])
                {
                    Console.WriteLine("Produto: " + produtos[linha, 0] + " custa " + produtos[linha, 3]);
                }
            }

            Console.WriteLine("Deseja pesquisar outro produto? S / N");
            pesquisar = Console.ReadLine();
        }
        break;
}
