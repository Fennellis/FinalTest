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
}