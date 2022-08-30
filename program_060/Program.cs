// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

bool Check(int value, int[,,] array){                                      //проверка на уникальность
    foreach (int i in array)
    {
        if (value==i) return false;
    }
    return true;
}


int[,,] ArrayGenerator(){                                                     //генератор массивов                         
    Random random = new Random();
    int[,,] array = new int[random.Next(2,6), random.Next(2,6), random.Next(2,6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (true)
                { 
                    int num = random.Next(100);
                    if(Check(num, array) != false){
                        array[i,j,k] = num;
                        break;
                    }
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,]array){                                          //Вывод значений
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i,j,k]}({i},{j},{j}) ");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] newArray = ArrayGenerator();
PrintArray(newArray);