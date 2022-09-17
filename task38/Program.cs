// Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 10;
double[] array = new double[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1,50); 
    Console.Write(array[i] + ", ");
}
double max = array [0];
double min = array [0];
for (int i = 1; i < size; i++)
{
    if (max < array[i]) max = array[i];

    if (min > array[i]) min = array[i];
}
double decision = max - min ;
System.Console.WriteLine($"{"\n"}Difference between {max} and {min} is : {decision}");