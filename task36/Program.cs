// Task 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 10;
int[] array = new int[size];
int count = 0;

for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(100); 
Console.Write(array[i] + "\t");
if (i % 2 != 0) count = count + array[i];
}

System.Console.WriteLine($"{"\n"}Sum of array elements with odd index: {count}");