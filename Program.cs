/*void Show2dArray(int[,] array)// метод выводит массив
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
            
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateSum2dArray(int m, int n)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m,n]; //выделили память для двумерного массива
    for(int i = 0;i<m;i++)//идет по столбцам
        for(int j = 0;j<n;j++)//идёт по строкам
            array[i,j]= i+j;//рандомно заполняем массив
    
    return array;
}
    Console.Write("Введите кол-во строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов n): ");
    int n = Convert.ToInt32(Console.ReadLine());


//Двумерные массивы
int[,] myArray = CreateSum2dArray(m,n);
Show2dArray(myArray);
*/

//задача №1
//Задайте двумерный массив размера m на n, каждый элемент в 
//массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран. 
//генерирующий
/*
//Задача №2
//Задайте двумерный массив. Найдите элементы, у которых оба индекса 
//чётные, и замените эти элементы на их квадраты.//метод void преобразующий
void Show2dArray(int[,] array)// метод выводит массив
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m,n]; //выделили память для двумерного массива
    for(int i = 0;i<m;i++)//идет по столбцам
        for(int j = 0;j<n;j++)//идёт по строкам
            array[i,j]= new Random().Next(min,max);//рандомно заполняем массив
    
    return array;
}
    Console.Write("Введите кол-во строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов n): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min элемент: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max элемент): ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

void ChangeIJElements(int[,] array)
{
    for(int i =0 ; i<array.GetLength(0);i++)
        for(int j =0 ; j<array.GetLength(1);j++)
        {
           //if(j%2==0&&i%2==0)
            array[i,j]=array[i,j]*array[i,j];
        }
}


//Двумерные массивы
int[,] myArray = CreateRandom2dArray(m,n,minValue,maxValue);
Show2dArray(myArray);
ChangeIJElements(myArray);
Show2dArray(myArray);
*/
//Задача №3
//Задайте двумерный массив. Найдите сумму элементов, находящихся на 
//главной диагонали (с индексами (0,0); (1;1) и т.д. метод возвращает int аналитический метод

void Show2dArray(int[,] array)// метод выводит массив
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "  ");
            
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m,n]; //выделили память для двумерного массива
    for(int i = 0;i<m;i++)//идет по столбцам
        for(int j = 0;j<n;j++)//идёт по строкам
            array[i,j]= new Random().Next(min,max);//рандомно заполняем массив
    
    return array;
}
    Console.Write("Введите кол-во строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов n): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min элемент: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max элемент): ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

int SumElementsIJ(int[,] array)
{
    int sum = 0;
    for(int i =0 ; i<array.GetLength(0)&&i<array.GetLength(1);i++)
      sum+=array[i,i];
    return sum;
}



//Двумерные массивы
int[,] myArray = CreateRandom2dArray(m,n,minValue,maxValue);
Show2dArray(myArray);
Console.WriteLine();
int sum = SumElementsIJ(myArray);
Console.WriteLine($"Сумма одинаковых индексов элементов массива = {sum}");
