//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите номер строки элемента: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (lines > numbers.GetLength(0) || columns > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента строки {lines} и  столбца {columns} равно {numbers[lines-1,columns-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}