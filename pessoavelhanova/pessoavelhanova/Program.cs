string nome, sexo, nome_maior, nome_menor;
int idade, idade_maior, idade_menor, homens, mulheres, i;

nome_maior = "";
nome_menor = "";
idade_maior = 0;
idade_menor = 1000;
homens = 0;
mulheres = 0;


for (i = 1; i <= 10; i++)
 { 

    Console.Clear();

    Console.WriteLine("qual o nome da " + i + " pessoa:");
    nome = Console.ReadLine();

    Console.WriteLine("qual a idade desta pessoa:");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine("qual seu sexo? masculino(M) | feminino(F)");
    sexo = Console.ReadLine();



    if (sexo == "M"|| sexo == "m")
    {
        homens++;
    }

    if (sexo == "F" || sexo == "f")
    {
        mulheres++;
    }

    if(idade <= idade_menor)
    {
        idade_menor = idade;
        nome_maior = nome;
    }

    if (idade >= idade_maior)
    {
        idade_menor = idade;
        nome_menor = nome;
    }


    Console.WriteLine("Maior idade é: " + nome_maior + "com" + idade_maior + "anos");
    Console.WriteLine(idade_menor);


}







