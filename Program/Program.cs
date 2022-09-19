string[] array = { "hello", "2", "world", ":-)" };
string[] array2 = new string[array.Length];
for (int i = 0; i < array.Length; i++)   // цикл по массиву
{
    if (array[i].Length <= 3) array2[i] = array[i]; // проверка условия
}
void PrintArray(string[] array)    // Метод печатает массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}
PrintArray(array2);
