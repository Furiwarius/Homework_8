// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] ArrayGenerator(){                                                     //генератор массивов                         
    Random random = new Random();
    int[,] array = new int[random.Next(2,6), random.Next(2,6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(20);
        }
    }
    return array;
}

void Sorting(int[,] array){                                     //сортировка
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = 0;
            int indexMax = 0;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max) {
                    max=array[i, k];
                    indexMax = k;
                }
            }
            if (max != array[i, j]) {
                array[i, indexMax] = array[i, j];
                array[i, j] = max;
            }
        }
    }
}

void PrintArray (int[,] array) {                              //вывод значений
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}


int[,] newArray = ArrayGenerator();
PrintArray(newArray);
System.Console.WriteLine();

Sorting(newArray);
PrintArray(newArray);