// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//  18 20
//  15 18

int[,] newArray = new int[2,2];
int[,] newArray2 = new int[2,2];

int[,] Filling(int[,] array){
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}

int[,] Multiplication(int[,] array1, int[,] array2){
    int[,] multArray = new int[2,2];

    for (int i = 0; i < multArray.GetLength(0); i++)
    {
        for (int j = 0; j < multArray.GetLength(1); j++)
        {
            int value = 0;
            for (int k = 0; k < multArray.GetLength(0); k++)
            {
                value += array1[i,k]*array2[k, j];
            }
            multArray[i, j] = value;
        }
    }
    return multArray;
}

void PrintArray(int[,]array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

Filling(newArray);
Filling(newArray2);

PrintArray(newArray);
System.Console.WriteLine();
PrintArray(newArray2);
System.Console.WriteLine();

int[,] multiArray = Multiplication(newArray, newArray2);
PrintArray(multiArray);