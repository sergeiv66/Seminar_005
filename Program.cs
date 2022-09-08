//Домашняя работа
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
int[] array = new int[10];

int count = 0;
int index = 0;
int length = array.Length; // array.Length = 10
while (index < length)
{
array[index] = new Random().Next(100, 1000); 
Console.Write(array[index] + "\t");

if (array[index] % 2 == 0) count++;
index++;
}
Console.WriteLine();

Console.WriteLine($"Количество четных чисел: {count}");  */


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] array = new int[4];

int sum = 0;
int index = 0;
int length = array.Length; 
while (index < length)
{
array[index] = new Random().Next(-100, 100); 
Console.Write(array[index] + "\t");
if (index %2 !=0) sum = sum + array[index];

index++;
}
Console.WriteLine();

Console.WriteLine($"Сумма нечетных элементов массива: {sum}"); */


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] array = new double[5];

int index = 0;
int length = array.Length; 
while (index < length)
{
array[index] = new Random().Next(100); 
Console.Write(array[index] + "\t");

index++;
}

double max = array[0]; double min = array[0];
for ( index = 0; index < array.Length; index++) 
{
    if (max < array[index]) max = array[index];
    if (min > array[index]) min = array[index];
}

double diff = max - min;

Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diff}"); 

