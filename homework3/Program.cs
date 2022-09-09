// Написать программу копирования массива

Console.OutputEncoding = System.Text.Encoding.UTF8;

void Fill(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void Print(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void Copy(int [,] array,int [,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i,j] = array[i,j];
        }
    }
}

int [,] massive = new int [10,10];
int [,] massive2 = new int [10,10];
Console.WriteLine("Создаём двумерный массив 10 на 10");
Fill(massive); // заполняем двумерный массив
Print(massive); // печатаем первый массив
Console.WriteLine();
Copy(massive,massive2);// делаем копию
Console.WriteLine("Теперь распечатываем копию нашего массива");
Print(massive2);//печатаем второй массив