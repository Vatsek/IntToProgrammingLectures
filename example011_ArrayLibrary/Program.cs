void FillArray(int[] collection) // void метод заполнения массива случайными числами от 1 до 10
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // void метод который выводит в консоль все элементы массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        
    }
    return position;
}




int[] array = new int[10]; /* new int[10]; - создай новый массив в котором 10 элементов. 
По умочанию он заполнен нулямию  */

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 45);
Console.WriteLine(pos);