/*Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)*/

Random rand = new Random();
int length = 10;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
    Console.Write($"{array[i]} ");
}

Array.Reverse(array);
Console.WriteLine();
Console.WriteLine(String.Join(',', array));
