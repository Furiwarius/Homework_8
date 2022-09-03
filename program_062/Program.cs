// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

bool Check(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == 0) return false;
        }
    }
    return true;
}

void SpiralArray(int[,] array, int direction = 1, int value = 1, int i = 0, int j = 0){
    // 1 - направо, 2 - вниз, 3 - налево, 4 - вверх
    if (direction==1){
        while (true)
        {
            if (array[i,j] != 0) break;
            array[i, j] = value;
            if (j+1 != array.GetLength(1)){
                if (array[i, j+1] == 0) {
                    j+=1; value+=1;
                } else break;
            } else break;
        }
        value+=1;
        i+=1;
    }
    else if (direction==2){
        while (true)
        {
            if (array[i,j] != 0) break;
            array[i, j] = value;
            if (i+1 != array.GetLength(0)){
                if (array[i+1, j] == 0) {
                    i+=1; value+=1;
                } else break;
            } else break;
        }
        value+=1;
        j-=1;
    }
    else if(direction==3){
        while (true)
        {
            if (array[i,j] != 0) break;
            array[i, j] = value;
            if (j-1 >= 0){
                if (array[i, j-1] == 0) {
                    j-=1; value+=1;
                } else break;
            } else break;
        }
        i-=1;
        value+=1;
    }
    else if(direction==4){
        while (true)
        {
            if (array[i,j] != 0) break;
            array[i, j] = value;
            if (array[i-1,j] == 0){
                if (array[i-1, j] == 0){
                    i-=1; value+=1;
                } else break;
            } else break;
        }
        value+=1;
        j+=1;
    }
    if (direction > 4) direction = 1; else direction+=1;
    if (Check(array) == false) SpiralArray(array, direction, value, i, j);
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
    System.Console.WriteLine();
}

Random random = new Random();
int[,] newArray = new int[random.Next(2,6), random.Next(2,6)];

SpiralArray(newArray);

PrintArray(newArray);