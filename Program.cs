Console.Write("Введите количество элементов массива: ");
string input = Console.ReadLine()!;
if (input == "")
{
    Console.WriteLine("Некорректный ввод");
    return;
}
int amount = int.Parse(input);

string[] stringArray = StringArray.CreateStringArray(amount);
Console.WriteLine($"Исходный массив -> [{string.Join(", ", stringArray)}]");
string[] newStringArray = StringArray.SelectionArray(stringArray);
Console.WriteLine($"Полученный массив -> [{string.Join(", ", newStringArray)}]");

class StringArray
{
    /// <summary>
    /// Создает массив строк длинной n
    /// </summary>
    /// <param name="n">Количество элементов массива</param>
    /// <returns>Возвращает массив</returns>
    public static string[] CreateStringArray(int n)
    {
        string[] array = new string[n];
        Console.WriteLine($"Введите элементы массива({n}): ");
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine()!;
        }
        return array;
    }
    /// <summary>
    /// Создает новый массив строк из элементов передаваемого массива строк, которые не более 3-х символов.
    /// </summary>
    /// <param name="inputArray">Передаваемый массив строк</param>
    /// <returns>Возвращает получившийся массив строк</returns>
    public static string[] SelectionArray(string[] inputArray)
    {
        Stack<string> stack = new();
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                stack.Push(inputArray[i]);
            }
        }
        string[] outputArray = stack.ToArray();
        Array.Reverse(outputArray);
        return outputArray;
    }
}