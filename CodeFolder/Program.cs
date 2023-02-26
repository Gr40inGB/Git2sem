void Main()
{
    System.Console.WriteLine("Программа разложит введённую строку на массив из слов," +
    " \nа затем выведет те элементы массива, длинна которых меньше или равны 3.");

    string s = EnterString("Введите строку: "); // "12 34 56 78";

    System.Console.WriteLine(s);

    string[] arr = SplitStringToArray(s);

    System.Console.WriteLine(String.Join(", ", arr));

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

Main();