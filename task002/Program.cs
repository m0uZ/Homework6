// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
// причем чтобы каждый гарантированно переместился на другое место 
// (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. То есть если массив три на четыре, 
// то надо выполнить не более 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.
void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
var rnd = new Random();
for (int i = 0; i < m * n / 2; i++)
{
    int r1 = rnd.Next(0, matrix.GetLength(0)),
        r2 = rnd.Next(0, matrix.GetLength(0)),
        c1 = rnd.Next(0, matrix.GetLength(1)),
        c2 = rnd.Next(0, matrix.GetLength(1));
    int temp = matrix[r1, c1];
    matrix[r1, c1] = matrix[r2, c2];
    matrix[r2, c2] = temp;
}
PrintArray(matrix);