// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] arr = new int[10];
Random rand = new Random ();
ArrayRandom(arr);

int count = 0;
for (int j = 0; j < arr.Length; j++)
if (arr[j] % 2 == 0)
count++;

Console.WriteLine($"{count} в массиве четные");

void ArrayRandom (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     arr[i] = rand.Next (100,1000);
    }
    Console.WriteLine ("[" + string.Join (", ", arr) + "]");
}



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = new int[10];
Random rand = new Random ();
ArrayRandom(arr);

int Sum = 0;
for (int j = 1; j < arr.Length; j+=2)
Sum = Sum + arr[j];

Console.WriteLine($"Cумма чисел на нечетных позициях = {Sum}");

void ArrayRandom (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     arr[i] = rand.Next(0,10);
    }
    Console.WriteLine ("[" + string.Join (", ", arr) + "]");
}
   



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = new double[10];
Random rand = new Random ();

ArrayRandom(arr);

double max = 0;
double min = 1;

for (int j = 1; j < arr.Length; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
    if (arr[j] < min)
    {
        min = arr[j];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void ArrayRandom (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     arr[i] = Convert.ToDouble(rand.Next(10,100));
    }
    Console.WriteLine ("[" + string.Join (", ", arr) + "]");
}

