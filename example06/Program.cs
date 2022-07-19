//задача 50.
Console.WriteLine("Введите число M, N: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число i0, j0: ");
int i0 = Convert.ToInt32(Console.ReadLine());
int j0 = Convert.ToInt32(Console.ReadLine());

/*if(i0>=M || j0>=N)
{
    Console.WriteLine("Вне диапазона");
}*/

//создание двухмерного массива.
double[,] array = new double [M, N];
// случайные числа.
Random rnd = new Random();
//передвигаемся по этим индексам с помощью циклов for.
for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        array[i,j] = rnd.Next(-10,10);
        /*if( i == i0 && j == j0)
        {
            Console.WriteLine("Элемент с j=j0 и i=i0", array[i, j]);
        }*/
        Console.Write(array[i, j]+ " ");
    }
    Console.WriteLine();
}
if(i0>=M || j0>=N || i0 < 0 || j0 < 0)
{
    Console.WriteLine("Вне диапазона");
}
else
{
    Console.WriteLine("Элемент с j=j0 и i=i0 {0}", array[i0, j0]);
}
