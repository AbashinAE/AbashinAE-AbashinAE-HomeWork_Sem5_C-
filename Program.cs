

//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GetRandomArray(5, 1, 99);
Console.WriteLine($"[{String.Join(",", array)}]");
int max = 0;
int min = 50;


foreach (int el in array)
{
  if (max < el) max = el;
  if (min > el) min = el;
}

Console.WriteLine($" Максимальный элемент: {max} Минимальный элемент: {min}");
Console.Write($"Разница между максимальным и минимальным элементом: {max - min}");

// -------------------------------Общий метод-------------------------------------------
double[] GetRandomArray(int size, int minValue, int maxValue)
{
  Random rnd = new Random();
  double[] result = new double[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = rnd.NextDouble() * 100; 
  }

  return result;
}