//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("напишите число");
int razmer = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(razmer);
Vivod(array);

Zamena(array);
Console.WriteLine();
Vivod(array);

int[,] GetArray(int razmer )
{   
    int[,] array = new int[razmer,razmer];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            array[i,g] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Vivod(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            Console.Write(" "+array[i,g]);
        }
        Console.WriteLine();
    }
}


void Zamena(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int g = 0; g < array.GetLength(1); g++)
        {
          for (int k = 0; k < array.GetLength(0) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int max = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = max;
                }
            }
        }
    }
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("напишите число");
int razmer1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = GetArray(razmer1);
Vivod(array1);
Console.WriteLine();

NumberMin(array1);
void NumberMin(int[,] array1)
{
    int min = 0;
    int min1 = 0;
    int sum = 0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        min += array1[0,i];
    }
    for (int f = 0; f < array1.GetLength(0); f++)
    {
        for (int g = 0; g <  array1.GetLength(1); g++) sum += array1[f,g];
        if(sum < min)
        {
            min = sum;
            min1 = f;
        }
        sum = 0;
    }
    Console.WriteLine(min1 + 1 + " строка");
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:


Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine("Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine("Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int g = 0; g < array.GetLength(1); g++)
    {
      array[i, g] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("трёхмерный массив из неповторяющихся двузначных чисел.");
int[,,] array3 = new int[2, 2, 2];
FillArray(array3);
PrintIndex(array3);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int g = 0; g < array3.GetLength(1); g++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                Console.Write($"{array3[i, g, k]}({i},{g},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:

Console.WriteLine("программа, которая заполнит спирально массив 4 на 4");
int n4 = 4;
int[,] sqareMatrix = new int[n4, n4];

int temp = 1;
int i4 = 0;
int g4 = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i4, g4] = temp;
  temp++;
  if (i4 <= g4 + 1 && i4 + g4 < sqareMatrix.GetLength(1) - 1)
    g4++;
  else if (i4 < g4 && i4 + g4 >= sqareMatrix.GetLength(0) - 1)
    i4++;
  else if (i4 >= g4 && i4 + g4 > sqareMatrix.GetLength(1) - 1)
    g4--;
  else
    i4--;
}

WriteArray4(sqareMatrix);

void WriteArray4 (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int g = 0; g < array.GetLength(1); g++)
    {
      if (array[i,g] / 10 <= 0)
      Console.Write($" {array[i,g]} ");

      else Console.Write($"{array[i,g]} ");
    }
    Console.WriteLine();
  }
}