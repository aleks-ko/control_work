/* Задача:
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

int Prompt (string msg)
{
    Console.Clear();
    Console.WriteLine(msg);
    string value = Console.ReadLine()!;
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.WriteLine("Неверный ввод. Повторите: ");
        value = Console.ReadLine()!;
    }
    return val;
}

void PrintArray (string[] Array) 
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"'{Array[i]}' ");
    }
}

int Reange_Array ()
{
    int Reange_Array = 0;
    while (Reange_Array<1)
    {
        Reange_Array = Prompt("Введите размер одномерного массива");
    }
    return Reange_Array;
}

string [] Input (int Reange_Array)
{
    int Var_Insert = 0;
    while (Var_Insert<1 || Var_Insert>2 )
    {
        Var_Insert = Prompt("Введите вариант заполнения где : 1 - ручной ввод, 2 - рандомное автозаполнение ");
    }
    string [] Input = new string [Reange_Array];
    {
        if (Var_Insert==1)
        {
            for (int i = 0; i < Reange_Array; i++)
            {
                Console.WriteLine($"Заполните {i+1} элемент из массива {Reange_Array} элементов");
                Input [i] = Console.ReadLine()!;
            }
        } else if (Var_Insert==2)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                int length = new Random().Next(1, 10);
            for (int i = 0; i < Reange_Array; i++)
            {
                Input [i] = new string(Enumerable.Repeat(chars, length).Select(s => s[new Random().Next(s.Length)]).ToArray());
                length = new Random().Next(1, 10);
            }
        }
    }
    return Input;
}

string [] New_Array (string[] Array) 
{
    int Count_New_Array=0;
    for (int i = 0; i < Array.Length; i++)
    {
        if ( Array[i].Length<4)
        {
            Count_New_Array++;
        }
    }
    string [] New_Array = new string [Count_New_Array];
    if (Count_New_Array>0)
    {
        int count = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            if ( Array[i].Length<4)
            {
                New_Array[count]=Array[i];
                count++;
            }
        }
    } else Console.WriteLine("Нет строк длина которых меньше, либо равна 3 символам");
    return New_Array;
}

string [] Array  = Input(Reange_Array());
PrintArray (Array);
Console.WriteLine();
PrintArray(New_Array(Array));