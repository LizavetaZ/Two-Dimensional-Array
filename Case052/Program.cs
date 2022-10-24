int m = InputValue("Введите количество строк");
int n = InputValue("Введите количество столбцов");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
int j = 0;
if (IsInputValidate(m, n, min, max))
{
    int[,] array = CreateArray(m, n, min, max);
    PrintArray(array);
    while(j < n)
    {
    double Average = FindAverage(array, 0, j);
    Console.WriteLine("Среднее арифметическое элементов столбца = " + Math.Round(Average, 2));
    j++;
    }
}
else Console.WriteLine("Ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}
bool IsInputValidate(int a, int b, int c, int d)
{
    if (a <= 0 || b <= 0 || c > d)
        return false;
    return true;
}
int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(min, max + 1);
        }
    }
    return a;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double FindAverage(int[,] Array, double Sum, int j)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Sum = Sum + Array[i, j];
    }
    return Sum / Array.GetLength(0);
}

