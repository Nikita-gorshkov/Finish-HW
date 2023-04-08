// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] UserArr(int size)
{
    string[] array = new string[size];
    return array;
}

Console.WriteLine("Vvedi kolichestvo strok:");
int userArrSize = int.Parse(Console.ReadLine()!);

void Mass(string[] array)
{
    int j = 0;
    for (int i = 1; i <= userArrSize; i++)
    {
        Console.WriteLine($"Stroka {i}: ");
        array[j] = Console.ReadLine()!;
        j = j + 1;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) 
         Console.Write($"[{array[i]} ");
        else if (i != array.Length - 1) 
        Console.Write($"{array[i]} ");
        else
        {
            Console.Write($"{array[i]}]");
            Console.WriteLine();
        }
    }
    if (array.Length == 0) 
    Console.WriteLine("PUSTO");
}

int GetResultArraySize(string[] array)
{
    int resultArraySize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
             resultArraySize = resultArraySize + 1;
    }
    return resultArraySize;
}

void ResultMassif(string[] userArray, string[] resultArray)
{
    int resArrElem = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            resultArray[resArrElem] = userArray[i];
            resArrElem = resArrElem + 1;
        }
        
    }
}


string[] userArray = UserArr(userArrSize);
Mass(userArray);
Console.WriteLine();
Console.Write("Ishodniy Massiv: ");
PrintArray(userArray);
int ArrSize = GetResultArraySize(userArray);
string[] resArray = UserArr(ArrSize);
ResultMassif(userArray, resArray);
Console.WriteLine();
Console.WriteLine();
Console.Write("Noviy massiv: ");
PrintArray(resArray);
Console.WriteLine();
Console.WriteLine();