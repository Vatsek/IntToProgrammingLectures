// Поиск индекса числа по содержимому
//             0  1  2  3  4   5   6   7
int[] array = {1, 5, 8, 4, 35, 46, 95, 35, 34};

int n = array.Length; // в переменной n будет назначена длина массива
 
 int find = 35;

 int index = 0;

 while (index < n)
 {
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1 ниже то же самое
    index++;
 }