// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] CreateArray(int size)
{
    string[] array = new string [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Enter array element: ");
        array[i] = Console.ReadLine();
    }
    return array;

}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] FinishArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) count++;

    }
    int j = 0;
    string[] newArray = new string[count];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}


Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = CreateArray(size);
ShowArray(newArray);
string[] myArray = FinishArray(newArray);
ShowArray(myArray);
