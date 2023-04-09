string[] MainArray = { "text1", "52", "-1", "15123", "0", "15", "123", "tex" };
Console.WriteLine("Пользовательский массив:");
Print(MainArray);
int CountChars(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}
string[] NewArray(string[] array, int NewArraySize)
{
    int index = 0;
    string[] massive = new string[NewArraySize];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            massive[index] = array[i];
            index++;
        }
    }
    return massive;
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array.Length - 1 == i)Console.Write($" {array[i]}]");
        else if (i == 0) Console.Write($"[{array[i]}");
        else if (i != array.Length) Console.Write($" {array[i]};");
    }

}
Console.WriteLine();
Console.WriteLine("Итоговый массив:");
int NewArraySize = CountChars(MainArray);
string[] array = NewArray(MainArray, NewArraySize);
Print(array);


