// // Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] inputArray = new string[8] { "hello", "world", "2", "321", "-2", "Kazan", ":-)", "Hi" };

string[] FilterArray(string[] inputArray, int symbolsCount)
{
    int itemsQnt = 0; 
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= symbolsCount)
        {
            itemsQnt++;
        }
    }
    string[] resultArray = new string[itemsQnt];
    int count = 0; 
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= symbolsCount)
        {
            resultArray[count] = inputArray[i];
            count++;
        }
    }
    return resultArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(FilterArray(inputArray, 3));