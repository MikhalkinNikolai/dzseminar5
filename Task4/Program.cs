// (не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца

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

int [,] DelArray(int [,] array){
    int [,] delArray = new int[array.GetLength(0)-1,array.GetLength(1)-1];
    int min = array[0,0];
    int rowIndex = 0;
    int colIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(min > array[i,j]){
                rowIndex = i;
                colIndex = j;
                min = array[i,j];
            }
        }
    }
    for(int i = 0; i < array.GetLength(0); i++){
        if (i == rowIndex){
            rowIndex = -1;
        }
        for(int j = 0; j < array.GetLength(1); j++){
            int x = 0;
                array[x,j] = array[i,j];
                x++;
        }
    }
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            int x = 0;
            if(j == colIndex){
                array[i,x] = array[i,j];
                x++;
            }
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


int [,] created2dArray = Create2dArray(row, col, min, max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int [,] delArray = DelArray(created2dArray);
Show2dArray(delArray);