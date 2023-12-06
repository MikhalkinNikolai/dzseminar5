// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void Position(int [,] array){
    Console.WriteLine("Введите первую координату");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вторую координату");
    int colIndex = Convert.ToInt32(Console.ReadLine());
    int i = rowIndex;
    int j = colIndex;
    if (i < array.GetLength(0) && j < array.GetLength(1)){
        Console.WriteLine($"{array[i,j]}");
    } else {
        Console.WriteLine("Элемента с такой позицией нет.");
    }
}

Console.WriteLine("Введите количество столбцов таблици");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк таблици");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row, col, min, max);
Console.WriteLine();
Show2dArray(created2dArray);
Position(created2dArray);