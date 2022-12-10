// See https://aka.ms/new-console-template for more information

Soma();

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
}