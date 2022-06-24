/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
  Найдите сумму элементов, стоящих на нечётных позициях.
  [3, 7, 23, 12] -> 19
  [-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];
int sumOdd = 0;


FillArrayRandomNumbers(array);
PrintArray(array);
SumOddNumbers(array);

void SumOddNumbers(int[] array)
{
for(int i = 1; i < array.Length; i ++)
   {
       if(i % 2 != 0)
       sumOdd += array[i];
   }
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOdd}");
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
      array[i] = new Random().Next(-20, 20);
   }
}