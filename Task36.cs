/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


//метод, который инициализирует массив из length элементов 
int [] InitArray(int length)
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-1000, 1000); 
}

return arr;
}

// метод, считает сумму элементов, стоящих на нечётных позициях



int SummArray(int [] array)
{
    //int [] newArray = new int [array.Length];
    int summ = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];     
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

int result = SumArray(workArray);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");