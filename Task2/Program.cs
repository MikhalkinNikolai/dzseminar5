// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] Create2dArray(int row, int col, int min, int max){
    int[,] array = new int [row, col];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] SvapArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            int index = array[array.GetLength(0) - 1,j];
            array[array.GetLength(0) - 1,j] = array[0,j];
            array[0,j] = index;
        }
    }
    return array;
}

Console.WriteLine("Введите количество столбцов таблици");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк таблици");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int [,] create2dArray = Create2dArray(row, col, min, max);
Console.WriteLine();
Show2dArray(create2dArray);
Console.WriteLine();
int [,] svapArray = SvapArray(create2dArray);
Show2dArray(svapArray);