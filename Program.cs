void Zadacha1(){
    // Задайте двумерный массив размером m×n, 
    // заполненный случайными вещественными числами.
    int rows = 4;
    int columns = 4;
    double[,] array = new double[rows, columns];
    FillArrayDouble(array);
    PrintArrayDouble(array);
}

void Zadacha2(){
    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.Write("Введите номер строки нухного эл-та: ");
    int numRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца нухного эл-та: ");
    int numCol = Convert.ToInt32(Console.ReadLine());
    if(numRows > rows || numCol > columns){
        Console.Write("Такого эл-та нет");
    }
    else{
        Console.Write(array[numRows - 1, numCol - 1]);
    }
}


void Zadacha3(){
    // Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    double average = 0;
    double sum = 0;
    Console.WriteLine("Среднее арифметическое: ");
    for(int i = 0; i < columns; i++){
        for(int j = 0; j < rows; j++){
            sum = sum + array[j, i];
        }
        average = Math.Round(sum / rows, 2);
        sum = 0;
        Console.Write(average + "\t");

    }
}


void FillArray(int [,] array, int startNumber = 0, int finishNumber = 100){
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            array[i, j] = random.Next(startNumber, finishNumber);
        }
        Console.WriteLine();
    }
}

void PrintArray(int [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArrayDouble(double [,] array, int startNumber = 0, int finishNumber = 100){
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            array[i, j] = Math.Round(random.Next(startNumber, finishNumber) + random.NextDouble(), 2);
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Zadacha1();
// Zadacha2();
Zadacha3();