int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 21, 331, 41, 51, 16, 71, 18, 9};
//array[0] = 12; пример как заменить значение в массиве
// Console.WriteLine(array[0]); вывести в консоль элемент массива


int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);


Console.WriteLine(max);
