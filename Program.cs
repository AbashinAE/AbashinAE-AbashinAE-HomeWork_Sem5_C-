//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет колличество чётных чисел в массиве.

int[] array = GetRandomArray(5, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int count = 0;

foreach (int el in array)
{
        if (el % 2 == 0) count++;
}
  
Console.WriteLine($" Колличествл четных чисел = {count}");

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
