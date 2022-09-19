double GetDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return Math.Round(distance, 2, MidpointRounding.ToNegativeInfinity);
}

Console.Write("Введите координату X(1 числа): ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y(1 числа): ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z(1 числа): ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату X(2 числа): ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y(2 числа): ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z(2 числа): ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Растояние между точкой A c координатами ({x1},{y1},{z1}) и точкой B c координатами({x2},{y2},{z2}) = {GetDistance(x1, y1, z1, x2, y2, z2)}");