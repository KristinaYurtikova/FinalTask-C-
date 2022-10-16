// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = new string[size];
string[] array1 = new string[size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}: ");
    array[i] = Console.ReadLine()!;
}

void CreateArrayLessOrEqualThreeCharacters(string[] array, string[] array1)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }

}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($" {array1[i]}");
    }
    Console.Write("]");
}
CreateArrayLessOrEqualThreeCharacters(array, array1);
Console.WriteLine();
PrintArray(array1);
