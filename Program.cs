int[] StringToArray(string arrayrow, int size)
{
    string[] row = arrayrow.Split(" ", size);
    
    int[] rowarray = new int[size];

    for(int i = 0; i < size; i++)
    {
        while(true)
        {
            if(int.TryParse(row[i], out rowarray[i])) break;
            Console.WriteLine("Неправильно введена строка массива!");
        }
    }

    return rowarray;
}

string ArrayRow(int size, int numberrow)
{
    string[] nameofrow = {"первую", "вторую", "третью", "четвертую", "пятую"};

    if(numberrow < 5)
    {
        Console.Write($"Введите {nameofrow[numberrow]} строку массива (числа через пробел, количество чисел {size}:");
        string row = Console.ReadLine();
        return row;
    }
    else
    {
        Console.Write($"Введите следующую строку массива (числа через пробел, количество чисел {size}:");
        string row = Console.ReadLine();
        return row;
    }
}

int GetSizeColArray()
{
    int size = 0;
    while(true)
    {
        Console.Write("Введите количество столбцов массива:");
        if(int.TryParse(Console.ReadLine(), out size)) break;
        Console.WriteLine("Ошибка ввода!");
    }
    return size;
}

int GetSizeRowArray()
{
    int size = 0;
    while(true)
    {
        Console.Write("Введите количество строк массива:");
        if(int.TryParse(Console.ReadLine(), out size)) break;
        Console.WriteLine("Ошибка ввода!");
    }
    return size;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}


/////////

int column = GetSizeColArray();
int row = GetSizeRowArray();

string strrow = string.Empty;
int[] arrrow = new int[column];

int[,] arr = new int[row, column];


for(int i = 0; i < row; i++)
{
    strrow = ArrayRow(column, i);
    arrrow = StringToArray(strrow, column);
    Array.Sort(arrrow);
    Array.Reverse(arrrow);
    for(int j = 0; j < column; j++)
    {
        arr[i, j] = arrrow[j];
    }
}

PrintArray(arr);

