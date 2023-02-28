// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

Figura figura = new Figura();

Console.WriteLine("¿Qué figura geométrica quieres calcular?");
Console.WriteLine("1. Círculo");
Console.WriteLine("2. Rectángulo");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Ingresa el radio del círculo:");
        double radio = double.Parse(Console.ReadLine());
        double areaCirculo = figura.CalcularAreaCirculo(radio);
        Console.WriteLine("El área del círculo es: " + areaCirculo);
        break;

    case 2:
        Console.WriteLine("Ingresa la base del rectángulo:");
        double baseRectangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa la altura del rectángulo:");
        double alturaRectangulo = double.Parse(Console.ReadLine());
        double areaRectangulo = figura.CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
        Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
        break;

    default:
        Console.WriteLine("Opción inválida.");
        break;
}

Console.ReadKey();
