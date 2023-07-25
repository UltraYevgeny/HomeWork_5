
/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int [] RandomArray()
{
    int size = new Random().Next(3,6);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100,1000);
    }
    return randomArray;
}

void ShowArray(int [] array)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

int[] myArray = RandomArray();
ShowArray(myArray);
int count = myArray.Length;
int lengthArray = 0;
for (int i = 0; i < count; i++)
{
    if (myArray[i] % 2 == 0)
    lengthArray += 1;
}
Console.WriteLine(" -> " + lengthArray);
*/


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int [] RandomArray()
{
    int size = new Random().Next(3,8);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-99,100);
    }
    return randomArray;
}

void ShowArray(int [] array)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

int[] myArray = RandomArray();
ShowArray(myArray);
int count = myArray.Length;
int sum = 0;
for (int i = 0; i < count; i++)
{
    if (i % 2 != 0)
    sum = sum + myArray[i];
}
Console.WriteLine(" -> " + sum);
*/


/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


double [] RandomArray()
{
    int size = new Random().Next(3,5);
    double[] randomArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(0,100) + new Random().NextDouble();
    }
    return randomArray;
}

void ShowArray(double [] array)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]:f2}, ");
    }
    Console.Write($"{array[array.Length-1]:f2}]");
}

double[] myArray = RandomArray();
ShowArray(myArray);
int count = myArray.Length;
double min = myArray[0];
double max = myArray[0];
for (int i = 0; i < count; i++)
{
    if (min > myArray[i])
    min = myArray[i];
}
for (int i = 0; i < count; i++)
{
    if (max < myArray[i])
    max = myArray[i];
}
Console.WriteLine($" => {max:f2} - {min:f2} = {max-min:f2}");
