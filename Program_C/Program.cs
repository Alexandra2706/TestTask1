int MAX_STRING_SIZE = 3;


int EnterArrayParam(string msg)
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out var number))
    {
        Console.WriteLine("Ошибка ввода");
        Environment.Exit(0);
    }
    return number;
}



int GetSizeArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= MAX_STRING_SIZE) size++;
    }
    return size;
}


string[] GetNewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= MAX_STRING_SIZE)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}



int arrSize = Math.Abs(EnterArrayParam("Введите размер массива: "));
int minValue = Math.Abs(EnterArrayParam("Введите минимальнимальную длину строки: "));
int maxValue = Math.Abs(EnterArrayParam("Введите максимальную длину строки: "));
if (minValue > maxValue)
{
    int temp = minValue;
    minValue = maxValue;
    maxValue = temp;
}



string[] array = arrSize.Create()
                    .Fill(minValue, maxValue);
Console.WriteLine("Исходный массив: ");
array.ConvertToStringAndPrint();

int lenNewArray = GetSizeArray(array);
string[] newArray = GetNewArray(array, lenNewArray);
Console.WriteLine("Новый массив: ");
newArray.ConvertToStringAndPrint();
