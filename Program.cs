
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
 int[] CreateArray(int size)
 {
     int[] array = new int[size];
     for(int i = 0; i < size; i++)
     {
         array[i] = new Random().Next(1, 1000);
     }
     return array;
 }

 void ShowArray(int[] array)
 {
     for(int i = 0; i < array.Length; i++)
     {
         Console.Write(array[i] + " ");
     }
 }


 int CountNum (int[] array)
 {
     int count = 0;
     for(int i = 0; i < array.Length; i++)
     {
         if(array[i] % 2 == 0) count++;
     }
     return count;
 }

 Console.Write("Input a number of elements: ");
 int number = Convert.ToInt32(Console.ReadLine());

 int[] myArray = CreateArray(number);

 ShowArray(myArray);
 int result = CountNum(myArray);
 Console.Write("The number of even numbers is " + result);
 */

 // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 /*
 int[] CreatedRandomArray(int size, int minValue, int maxValue)
 {
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
 }

 void ShowArray(int[] array)
 {
     for(int i = 0; i < array.Length; i++)
     {
         Console.Write(array[i] + " ");
     }
 }

 int SumOfNumbers (int[] array)
 {
     int sum = 0;
     for(int i = 0; i < array.Length; i++)
     {
         if(i % 2 != 0) 
         {
             sum += array[i];
         }
     }
     return sum;
 }

 Console.Write("Input a number of elements: ");
 int number = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a min possible value: ");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a max possible value:");
 int b = Convert.ToInt32(Console.ReadLine());

 int[] myArray = CreatedRandomArray(number, a, b);

 ShowArray(myArray);

 int result = SumOfNumbers(myArray);
 Console.Write("Sum of elements at odd even in an array " + result);
 */

 // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 /*
 double[] CreateArray(int size, int minValue, int maxValue)
 {
    Random rnd = new Random();
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = rnd.NextDouble() + rnd.Next(minValue, maxValue + 1);
    
    return array;
 }
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double DifferenceMaxMin(double[] array)
{
    double maxnum = array[0];
    double minnum = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxnum)
            maxnum = array[i];
        else
            if(array[i] < minnum)
                minnum = array[i];
    }
    double result = maxnum - minnum;
    return result;    
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(size, min, max);
ShowArray(myArray);
double difference = DifferenceMaxMin(myArray);
Console.WriteLine("Difference between max and min elements " + difference);
*/
