/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

//метод, который инициализирует массив из length элементов 
int [] InitArray(int length)
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(100, 1000); 
}

return arr;
}

// метод, который ищет и считает кол-во четных чисел в массиве



int PositiveArray(int [] array)
{
    //int [] newArray = new int [array.Length];
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
           summ = summ + 1;
       }
    
    }
    return summ;
} 


//метод, который печатает массив на консоль

void PrintArray(int [] arr)
{
foreach(int item in arr)
Console.Write($"{item} ");
}


Console.WriteLine("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] workArray = InitArray(length);
PrintArray(workArray);

int result = PositiveArray(workArray);

Console.WriteLine($"Количество чётных чисел в массиве: {result}");


