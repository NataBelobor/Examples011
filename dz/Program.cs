//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, 
//стоящих на нечётных позициях.

Console.Write($"Введи количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine()); 

int Random (int numbers, int min, int max)
  {
  int[] array = new int[numbers];
  int n = 0;
  Console.Write(": ");

    for (int i = 0; i <array.Length; i++ ){
      array[i] = new Random().Next(min, max);

      Console.Write(array[i] + " ");

      if (i % 2 != 1)
      {
        n = n + array[i];
      }
    }
  return n;
  }

int array =  Random (numbers, -99, 100);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {array}");
