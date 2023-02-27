void Main()
{
    System.Console.WriteLine("Программа разложит введённую строку на массив из слов," +
    " \nа затем выведет те элементы массива, длинна которых меньше или равны числу, которое будет указано далее.");

    string s = EnterString("Введите строку: ");
    string[] arr = SplitStringToArray(s);
    int countSrt = EnterCount("Введите длинну строки для отбора: ");
    string[] selectedArr = SelectArr(arr, countSrt);
    PrintArray(arr);
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
    int[] selectIndexs = new int[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= l)
            selectIndexs[count++] = i;
    }

    string[] selArr = new string[count];
    for (int j = 0; j < count; j++)
    {
        selArr[j] = arr[selectIndexs[j]];
    }
    return selArr;
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