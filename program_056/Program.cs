// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SearchForTheSmallest (int[,] array){
    int len = 0;
    int str = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int crutch = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            crutch+=array[i, j];
        }
        if (i==0) len=crutch;
        else{
            if (len>crutch){
                len = crutch;
                str=i;
            }
        }
    }
    return str;
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
int length = SearchForTheSmallest(newArray);

PrintArray(newArray);
System.Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {length+1} строка");