int row = InputValue("Введите количество строк");
int colom = InputValue("Введите количество столбцов");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
if (IsInputValidate(row, colom, min, max))
{
    int[,] array = CreateArray(row, colom, min, max);
    PrintArray(array);
    Console.WriteLine();
    int index = 0;
    int[] OneRangeArray = new int[row * colom];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colom; j++)
        {
            OneRangeArray[index] = array[i, j];
            index++;
        }
    }
    PrintOneRangeArray(OneRangeArray);
    SortArray(OneRangeArray, 0);
    Console.WriteLine();
    int count = 1;
    int Value = OneRangeArray[0];
    for (int i = 1; i < OneRangeArray.Length; i++)
    {
        if (Value == OneRangeArray[i])
        {
            count = count++;
        }
        else
        {
            Console.WriteLine($"Количество элементов {OneRangeArray[i - 1]} = {count}");
            count = 1;
            Value = OneRangeArray[i];
        }
    }
    Console.WriteLine($"Количество элементов {Value} = {count}");
}
else Console.WriteLine("Ошибка вводимых данных");

void SortArray(int[] arr, int k)
{
    for ( k = 0; k < arr.Length - 1; k++)
    {
        if (arr[k] > arr[k + 1])
        {
            int temp = arr[k];
            arr[k] = arr[k + 1];
            arr[k + 1] = temp;
            k++;
        }
        else
        { 
            k++; 
        }
    }
}

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
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

bool IsInputValidate(int a, int b, int c, int d)
{
    if (a <= 0 || b <= 0 || c > d || a != b)
        return false;
    return true;
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

void PrintOneRangeArray(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i] + " ");
    }
}
