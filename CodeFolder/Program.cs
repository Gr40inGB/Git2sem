void Main()
{
    System.Console.WriteLine("Программа разложит введённую строку на массив из слов," +
    " \nа затем выведет те элементы массива, длинна которых меньше или равны числу, которое будет указано далее.");

    string s = EnterString("Введите строку: "); // "12 34 56 78";

    System.Console.WriteLine(s);

    string[] arr = SplitStringToArray(s);

    System.Console.WriteLine(String.Join(", ", arr));

    int countSrt = EnterCount("Введите длинну строки для отбора: ");
    System.Console.WriteLine(countSrt);

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

Main();