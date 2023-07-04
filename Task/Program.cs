/* Задача:
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

int Prompt (string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine()!;
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.WriteLine("Неверный ввод. Повторите: ");
        value = Console.ReadLine()!;
    }
    //Console.Clear();
    return val;
}

void PrintArray (string[] Array) 
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"'{Array[i]}' ");
    }
}

int Reange_Arey = 0;
int Var_Insert = 0;

while (Reange_Arey<1)
{
    Reange_Arey = Prompt("Введите размер одномерного массива");
}

while (Var_Insert<1 || Var_Insert>2 )
{
    Var_Insert = Prompt("Введите вариант заполнения где : 1 - ручной ввод, 2 - рандомное автозаполнение ");
}

string [] Input = new string [Reange_Arey];
{
    if (Var_Insert==1)
    {
        for (int i = 0; i < Reange_Arey; i++)
        {
            Console.WriteLine($"Заполните {i+1} элемент из массива {Reange_Arey} элементов");
            Input [i] = Console.ReadLine()!;
        }
    } else if (Var_Insert==2)
    {
        for (int i = 0; i < Reange_Arey; i++)
        {
            Console.WriteLine($"Заполните {i+1} элемент из массива {Reange_Arey} элементов");
            Input [i] = Console.ReadLine()!;
        }
    }
}
PrintArray (Input);