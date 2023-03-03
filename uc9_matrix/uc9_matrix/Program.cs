string nome;
string sexo;
string homens;
string mulheres;
int idade_maior;
int idade_menor;
int idade;

idade_maior = 0;
idade_menor = 200;

int i;

    for (i = 1; i <= 10; i++)
    {

    Console.WriteLine("informe o seu nome:");
    nome = (Console.ReadLine());

    Console.WriteLine("informe sua idade:");
    idade = int.Parse ((Console.ReadLine()));
    
   Console.WriteLine("informe o seu sexo:");
   sexo = (Console.ReadLine());

    if (idade_menor < idade)
    {
        Console.WriteLine(idade_menor);

    }
    




}

