// Задание:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3.
string[] array1 = new string[4] { "Word", "yes", "no", "..." };
string[] array2 = new string[array1.Length];
void Selection(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
            array2[count] = array1[i];
        count++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
Selection(array1, array2);
PrintArray(array2);