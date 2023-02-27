void Main()
{
    Console.Clear();
    System.Console.WriteLine("Программа разложит введённую строку на массив из слов, а затем выведет те элементы массива," +
    " \nдлина которых меньше или равна числу, которое будет указано далее.");

    string inputedStr = EnterString("Введите строку: ");
    string[] arrayFromStr = SplitStringToArray(inputedStr);
    int countSrt = EnterCount("Введите длинну строки для отбора: ");
    string[] selectedArr = SelectArr(arrayFromStr, countSrt);
    PrintArray(arrayFromStr);
    System.Console.Write(" -> ");
    PrintArray(selectedArr);
}

string[] SplitStringToArray(string s)
{
    char[] separators = new char[] { ' ', '.', ',', '!', ';', '?' };
    string[] subS = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return subS;
}

string EnterString(string welcomeToInput)
{
    System.Console.Write(welcomeToInput);
    return Console.ReadLine()!;
}

int EnterCount(string welcomeToInput)
{
    bool inputOk = false;
    int count = 0;
    while (!inputOk)
    {
        System.Console.Write(welcomeToInput);
        string inp = Console.ReadLine()!;
        inputOk = int.TryParse(inp, out int n);
        if (inputOk)
            count = n;
        else
            System.Console.Write("Вы ввели не число. ");
    }
    return count;
}

string[] SelectArr(string[] arr, int l)
{
    int[] selectIndexs = new int[arr.Length]; // массив для хранения нужных нам индексов
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= l)            // отбор по условию
            selectIndexs[count++] = i;
    }

    string[] selectedStringsArray = new string[count];  // нужный нам массив, его вернёт функция
    for (int j = 0; j < count; j++)
    {
        selectedStringsArray[j] = arr[selectIndexs[j]];
    }
    return selectedStringsArray;
}

void PrintArray(string[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write('\u0022' + arr[i] + '\u0022' + (i < arr.Length - 1 ? ", " : ""));
    }
    System.Console.Write("]");
}

Main();