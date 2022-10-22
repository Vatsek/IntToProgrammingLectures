//  Вид 1 - Метод который ничего не принимает и ничего не возвращает
void Method()
{
    Console.WriteLine("Какой либо текст");
}

//Method(); // так пишется когда нужно вызвать этот метод

// Вид 2 - Метод который принимает, но ничего не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Реклама", 5);
//Method21(count: 5, msg: "Какой то текст"); // можно указывать какому аргументу какое значение

//Вид 3 Метод который ничего не принимает, но что то возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 - метод который что то принимает и что то возвращает.
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
*/


/* string Method4(int count, string text)
{  
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/

/*for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

/*Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”,
 а большие “С” заменить маленькими “с”.
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали "
                + "вместо нашего милого Винценгероде, вы бы взяли приступом согласие"
                + "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] // r

/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
*/

//сортировка массива от min к max

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// метод, который выводит все данные массива
void PrintArray(int[] array) 
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
// метод, который расставляет элементы массива от меньшего к большему
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j;    
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
