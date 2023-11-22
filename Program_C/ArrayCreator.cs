// Создание массива
using System.Text;


/// <summary>
///  это класс, отвечающий за создание массива
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>Новый массив</returns>
    public static string[] Create(this int n)
    {
        return new string[n];
    }

    /// <summary>
    /// Переводит массив в строку
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Строку с представлением массива</returns>
    public static string ConvertToStringAndPrint(this string[] array)
    {
        string sep = "\", \"";
        string str = $"[\"{String.Join(sep, array)}\"]";
        Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Заполняет массив
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Минимальная длина строки</param>
    /// <param name="max">Максимальная длина строки</param>
    public static string[] Fill(this string[] array, int min = 1, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        for (int i = 0; i < array.Length; i++)
        {
            int lenString = random.Next(min, max);
            array[i] = GetRandomString(lenString);
        }

        return array;
    }

    /// <summary>
    /// Генерирует случайную строку
    /// </summary>
    /// <param name="lenString">длина случайно строки</param>
    /// <returns>случайную строку</returns>
    public static string GetRandomString(int lenString)
    {
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789{}[]., :();-+=".ToCharArray();
        Random random = new Random();
        string word = String.Empty;
        for (int i = 0; i < lenString; i++)
        {
            int numLetter = random.Next(0, letters.Length - 1);
            word += letters[numLetter];
        }
        return word;
    }
}