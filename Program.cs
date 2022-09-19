string GetTripleTable(int n)
{
    string tripleString = "";
  
    if(n<1)
    { 
        return "Введено неверное число, попробуйте снова";
    }
    else 
    {
    for (int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}";
        }
        else
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}, ";
        }
    }
    return tripleString;
    }
}

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.Write($"Таблица кубов от 1 до {x} = {GetTripleTable(x)}");
