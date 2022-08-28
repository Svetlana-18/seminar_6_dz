// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел, которое будет проверяться: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreationArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

int CoutingPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
void PrintArray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1) Console.Write($"{array1[i]},");
        else Console.Write(array1[i]);
    }
    Console.Write("]");
}

int[] array = CreationArray(number);
int count = CoutingPositiveNumbers(array);
PrintArray(array);
Console.WriteLine($" Количество положительных элементов = {count} ");


// Console.WriteLine("Введите количество чисел: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array_new = new int[n];
// int i=0;
// while (i<n)
// {
//     Console.WriteLine($"Введите {i+1}-й числа"); 
//     array_new[i]=Convert.ToInt32(Console.ReadLine());
//     i++;
// }
// Console.Write($"[");
// for (i = 0; i < n; i++){
// Console.Write($"{array_new[i]} ");
// }
// Console.Write($"]");

// int count = 0;
// for (i = 0; i < n; i++)
// {

// if (array_new[i] > 0)
// count ++;
// }
// Console.WriteLine();
// Console.WriteLine($" Количество положительных элементов = {count}");


