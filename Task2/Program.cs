/* Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] CreateArray()
{
    Console.WriteLine("введите размер массива ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(99, 999);
    }
    return array;
}

int Task(int[] array)
{
    int count_number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count_number++;
        }
    }
    return count_number;
}

int[] array = CreateArray();
int count_number = Task(array);

Console.WriteLine("в массиве " + string.Join(", ", array) + " число четных чисел " + count_number);
