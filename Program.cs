

//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

int[] array = GetRandomArray(5, 1, 99);
Console.WriteLine($"[{String.Join(",", array)}]");

int Sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i%2!=0)
    Sum = Sum +array[i];
}

Console.WriteLine($" sum = {Sum}");

// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }

  return result;
}