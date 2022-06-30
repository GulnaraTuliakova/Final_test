/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клаиватуры,
либо задать на старте выполнения алгоритма. */
Console.WriteLine();
string[] array = new string[] { "Hello", "friends", "I", "glad", "to", "see", "you" };
Console.Write($"Первоначальный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine();
Console.Write($"Массив, содержащий слова, состоящие из 3х и менее символов : ");
for (int i = 0; i < array.Length; i++)
{
    int str = array[i].Length;
    if (str <= 3)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine();
Console.WriteLine();