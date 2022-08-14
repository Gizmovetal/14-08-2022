Console.Clear();
int N =0;
InputNByUser(ref N); 
CheckAndPrintResult(N);

static void InputNByUser (ref int n)
{
    try
    {
        Console.Write("Введите N: ");
        n = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}


static void CheckAndPrintResult (int n)
{
    if (n.ToString().Length < 6 && n.ToString().Length > 4)
    {
        if (n.ToString()[0] == n.ToString()[4] && n.ToString()[1] == n.ToString()[3])
        {
            Console.WriteLine($"N = {n} - палиндром");
        }
        else
        {
            Console.WriteLine($"N = {n} - НЕ палиндром");
        }
    }
    else
    {
        Console.WriteLine("Введите пятизначное число!");
    }
    
}

