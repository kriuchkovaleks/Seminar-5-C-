/*  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

// метод, считает разницу между максимальным и минимальным элементов массива


int differenceArray(int [] array)
{
    int max = array[0];
    int min = array[1];
    
    if (min > max )
    {
        max = array[1];
        min = array[0];
    } 
    else
    {
        int i = 0;
        while (i < array.Length)
        {
            if (array[i] > max)
                max = array[i];
            else 
                {
                    if (array[i] < min)
                    min = array[i];
                    else 
                        i++;
                }
        i++;
        }
    }


    Console.WriteLine($" max: {max}, min: {min}");
    int diff = max - min;
    return diff;
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

int result = differenceArray(workArray);

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {result}");
