/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
  Напишите программу, которая покажет количество чётных чисел в массиве.
  [345, 897, 568, 234] -> 2
*/

int[] array = new int[4];

int evenNumbers = 0;

FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i ++)
{
   if(array[i] % 2 == 0)
   evenNumbers++;
}
Console.WriteLine($"количество четных чисел в массиве: {evenNumbers}");

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
      array[i] = new Random().Next(100, 1000);
   }
}