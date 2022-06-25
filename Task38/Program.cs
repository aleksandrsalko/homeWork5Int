/*Задача 38: Задайте массив вещественных чисел. 
  Найдите разницу между максимальным и минимальным элементов массива.
  [3 7 22 2 78] -> 76
*/

int[] array = new int[5];



FillArrayRandomNumbers(array);
PrintArray(array);
DiffMaxMin(array);

void DiffMaxMin(int[] array)
{
int max = array[0];
int min = array[0]; 
int difference = 0; 
for(int i = 0; i < array.Length; i ++)
   {
       if(max < array[i])
       {
         max = array[i];
       }
       if(min > array[i])
       {
         min = array[i];
       }
   }
difference = max - min;

Console.WriteLine($"{max}-{min}={difference}");
}

void PrintArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i] + " ");
   }
Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
   for(int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0,100);
   }
}