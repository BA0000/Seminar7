// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// Console.Write("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());


// double[,] array = new double[m,n];

// void Create2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-30, 200)) / 20;
//         }
//     }
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine(" ");
//     }
// }


// Create2dArray(array);

// Show2dArray(array);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.


// Console.Write("Enter line position: ");
// int line = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter column position: ");
// int column = Convert.ToInt32(Console.ReadLine());


// int[,] array = new int[10, 10];

// void Create2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine();
//     }
// }


// void ElementPosition(int[,] array)
// {
//  if(line > array.GetLength(0) || column > array.GetLength(0))
//   {
//     Console.Write("No element ");
//   }

// else
//   {
//     Console.Write($"value of line {line} and column {column} is {array[line-1, column-1]}");
//   }
  
//   Console.WriteLine();
// }


// Create2dArray(array);

// Show2dArray(array);

// ElementPosition(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// Console.Write("Enter quantity of lines: ");
// int line = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter quantity of columns: ");
// int column = Convert.ToInt32(Console.ReadLine());



// int[,] array = new int[line, column];

// void GiveMeArray(int[,] array)
// {
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     array[i, j] = new Random().Next(1, 10);
//   }
// }

// void ShowMeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine();
//     }
// }


// void ArMean(int[,] array)
// {
//     double avarage = 0; 
//     for(int j = 0; j < array.GetLength(1); j++)
      
//       {
//         for (int i = 0; i < array.GetLength(0); i++)
//          avarage = (avarage + array[i, j]);
//       }
    

//     avarage = avarage / column;
//     Console.Write(avarage + "; ");
//     Console.WriteLine();
// }


// Console.WriteLine($"avarage number of elements in each column is: ");

// GiveMeArray(array);
// ShowMeArray(array);
// ArMean(array);


// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// С последней задачей не справился совсем. Выходит не совсем тот результат.
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------------------------------------------------------------








