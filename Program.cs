
using System.Runtime.Intrinsics;

MainMenu();
static void MainMenu()
{
    Console.WriteLine("Escolha a operação matemática desejada: ");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    int operacao = int.Parse(Console.ReadLine());
    if (operacao == 5)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    double resultado = 0;

    switch (operacao)
    {
        case 1: resultado = Soma(valor1, valor2); break;
        case 2: resultado = Subtracao(valor1, valor2); break;
        case 3: resultado = Multiplicacao(valor1, valor2); break;
        case 4: resultado = Divisao(valor1, valor2); break;
        default: MainMenu(); break;

    }

    Console.WriteLine($"O resultado da operação é: {resultado}");
    Console.WriteLine("-- Retornando ao Menu Principal --");
    Console.ReadKey();
    Console.Clear();
    MainMenu();

}


static double Soma(double v1, double v2)
{
    return v1 + v2;
}

static double Subtracao(double v1, double v2)
{
    return v1 - v2;
}

static double Multiplicacao(double v1, double v2)
{
    return v1 * v2;
}

static double Divisao(double v1, double v2)
{
    return v1 / v2;
}




