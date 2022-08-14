Console.Clear();
int X1 = 0, Y1 = 0, Z1 = 0, X2 = 0, Y2 = 0, Z2 = 0;

InitCoordinatesByUser(ref X1, ref Y1, ref Z1, ref X2, ref Y2, ref Z2);
CheckAndPrintDistance(X1, Y1, Z1, X2, Y2, Z2);

static void InitCoordinatesByUser(ref int x1, ref int  y1, ref int  z1, ref int  x2, ref int  y2, ref int z2)
{
    try
    {
        Console.Write("Введите X1: ");
        x1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y1: ");
        y1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z1: ");
        z1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите X2: ");
        x2 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y2: ");
        y2 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z2: ");
        z2 = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void CheckAndPrintDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    Console.WriteLine($"Введено: точка А ({x1}, {y1}, {z1}) и точка В ({x2}, {y2}, {z2}).");
    Console.WriteLine($"Расстояние между точками: {result}");
}