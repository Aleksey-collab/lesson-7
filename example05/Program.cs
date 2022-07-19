//задача 47.
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
//создание двухмерного массива.
double[,] array = new double [M, N];
// случайные числа.
Random rnd = new Random();
//передвигаемся по этим индексам с помощью циклов for.
for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        array[i,j] = rnd.NextDouble();
        Console.Write(array[i, j]+ " ");
    }
    Console.WriteLine();
}