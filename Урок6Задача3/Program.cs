// Сгенерировать двумерный массив со случайными числами, вывести его на экран, оформить в виде функций 
// (пригодится в дальнейшем)

int Prompt(string message)
{
    System.Console.Write(message);                     // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine());  // Считывает значение
    return result;                                     // Возвращает результат
}


int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )    // Функция создания и заполнения двумерного массива по формуле
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)       // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // Столбец
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);       // 0, 20 по умолчанию
        }
    }   
    return matrix;                  
}


void PrintArray(int[,] matrix)                         // Функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)      // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");
int maxRand = Prompt("Введите верхнюю границу диапазона ");           // Необязательно
int minRand = Prompt("Введите нижнюю границу диапазона ");            // Необязательно
int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand);     // Диапазон значений можно не устанавливать
PrintArray(matrix);