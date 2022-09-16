Console.Clear();


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.Write("введите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int row, int column)

// {
//     int[,] matrix = new int[row, column];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10, 100);
//         }
//     }
//     return matrix;
// }

// int[,] SortRow(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int minPosition = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, minPosition]) minPosition = k;
//             }
//             int tmp = array[i, j];
//             array[i, j] = array[i, minPosition];
//             array[i, minPosition] = tmp;
//         }

//     }
//     return array;
// }

// void PrintTable(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] table = GetMatrix(row, column);
// PrintTable(table);

// Console.WriteLine();
// int[,] rowSort = SortRow(table);
// PrintTable(rowSort);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


// int[,] table = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
// GetMatrixRandom(table);
// PrintMAtrix(table);
// Console.WriteLine();
// NumberRowMinSumElements(table);

// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minRow += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"в {minSumRow + 1} строчке наименьшая сумма элементов");
// }

// void PrintMAtrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void GetMatrixRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
// }




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int[,] secondMatrix = new int[rows, columns];
// int[,] resultMatrix = new int[rows, columns];

// GetMatrixRandom(matrix);
// PrintMatrix(matrix);

// Console.WriteLine();

// GetMatrixRandom(secondMatrix);
// PrintMatrix(secondMatrix);

// Console.WriteLine();

// if (matrix.GetLength(0) != secondMatrix.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < secondMatrix.GetLength(1); j++)
//     {
//         resultMatrix[i, j] = 0;
//         for (int k = 0; k < matrix.GetLength(1); k++)
//         {
//             resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
//         }
//     }
// }

// PrintMatrix(resultMatrix);

// void GetMatrixRandom(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] matrix3D = new int[2, 2, 2];
// GetMatrix(matrix3D);
// PrintIndex(matrix3D);

// Console.WriteLine();

// void PrintIndex(int[,,] value)
// {
//     for (int i = 0; i < matrix3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < matrix3D.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");

//             }
//         }
//     }
//     Console.WriteLine();
// }

// void GetMatrix(int[,,] value)
// {
//     int count = 10;
//     for (int i = 0; i < value.GetLength(0); i++)
//     {
//         for (int j = 0; j < value.GetLength(1); j++)
//         {
//             for (int k = 0; k < value.GetLength(2); k++)
//             {
//                 value[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int row = 4, column = 4;
int[,] MatrixSpiral = new int[row, column];
GetMatrixSpiral(MatrixSpiral, row);
PrintMatrix(MatrixSpiral);

void GetMatrixSpiral(int[,] MatrixSpiral, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { MatrixSpiral[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) MatrixSpiral[i++, j] = value++;
        for (k = 0; k < n - 1; k++) MatrixSpiral[i, j--] = value++;
        for (k = 0; k < n - 1; k++) MatrixSpiral[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintMatrix(int[,] MatrixSpiral)
{
    for (int i = 0; i < MatrixSpiral.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixSpiral.GetLength(1); j++)
        {
            if (MatrixSpiral[i, j] < 10)
            {
                Console.Write("0" + MatrixSpiral[i, j]);
                Console.Write(" ");
            }
            else Console.Write(MatrixSpiral[i, j] + " ");
        }
        Console.WriteLine();
    }
}