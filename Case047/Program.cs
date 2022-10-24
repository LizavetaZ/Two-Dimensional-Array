int m = InputValue("Введите количество строк");
int n = InputValue("Введите количество столбцов");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
if (IsInputValidate(m, n, min, max))
{
    double[,] array = CreateArray(m, n, min, max);
    PrintArray(array);
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
    if (a <= 0 || b <= 0 || c>d)
        return false;
    return true;
}
double[,] CreateArray(int M, int N, int min, int max)
{
    double[,] a = new double[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            a[i, j] = min + new Random().NextDouble() * (max - min);
        }
    }
    return a;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}
