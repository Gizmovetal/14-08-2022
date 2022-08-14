Console.Clear();
int N = 0;
InputNByUser(ref N); 
DoAndPrintResult(N);

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


static void DoAndPrintResult (int n)
{   
    if (n == 0)
        {
            Console.WriteLine($"Перезапустите приложение, повторите ввод.");  
        }
        else
        {
            Console.WriteLine($"Введено число N = {n}, таблица кубов от 1 до N:");
            int i = 1;
            while (i<=n)
        {   
            Console.Write($"{Math.Pow(i,3)}, ");
            i++;
        }
        }
}
