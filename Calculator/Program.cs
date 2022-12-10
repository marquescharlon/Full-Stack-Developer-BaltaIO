// See https://aka.ms/new-console-template for more information

// Soma();
// Subtracao();
// Divisao();
Multiplicacao();

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    var resultado = v1 + v2;
    // Console.WriteLine("O resultado da soma é " + resultado);
    Console.WriteLine($"O resultado da soma é {resultado}");
    // Console.WriteLine($"O resultado da soma é {v1 + v2}");
    // Console.WriteLine("O resultado da soma é " + (v1 + v2));

    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    var resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    var resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    var resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();
}