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
        string[] outputArray = Array.Empty<string>();
        int n = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                n++;
                Array.Resize(ref outputArray, n);
                outputArray[n - 1] = inputArray[i];
            }
        }
        return outputArray;
    }
}