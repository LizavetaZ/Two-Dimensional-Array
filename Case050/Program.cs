int m = InputValue("Введите количество строк");
int n = InputValue("Введите количество столбцов");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
int row = InputValue("Введите значение строки элемента");
int colom = InputValue("Введите значение столбца элемента");
if (IsInputValidate(m, n, min, max, row, colom))
{
int[,] array = CreateArray(m, n, min, max);
PrintArray(array);
if (ArrayAnalize(row, colom, array)) Console.WriteLine("Заданные координаты соответствуют элементу " + array[row-1,colom-1]);
else Console.WriteLine("такого элемента в заданном массиве нет");
}
else Console.WriteLine("Ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}
bool IsInputValidate(int a, int b, int c, int d, int e, int f)
{
    if (a <= 0 || b <= 0 || c>d || e<=0 || f<=0)
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

bool ArrayAnalize(int a, int b, int[,] array)
{
if (a > (array.GetLength(0)-1) || b > (array.GetLength(1)-1))
    return false;
return true;
}

