// Программа из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Массив можно ввести с клавит, либо задать на 
//старте выполнения алгоритма. При решении лучше использовать массивы, а не коллекции.

// Считываем кол-во элементов массива
int ReadData(string line)
{   
    Console.WriteLine(line);  
    int x1= int.Parse(Console.ReadLine() ?? "0");    
    return x1;  
}

// Метод формирование строкового массива
string[] GenArray(int arrayLength)
{   Console.WriteLine("Вводите элементы массива и нажимайте Enter");  
    string[] array = new string[arrayLength];               
    for (int i = 0; i < array.Length; i++)
    {           
        array[i] =  Console.ReadLine() ?? "0";             
    }
return array;
}

// Формируем массив из элементов длинной <= 3 символам
string[] ResultArray(string[] array)
{   
    string resString = "";
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i].Length <= 3)
        {
            resString = resString + array[i] + ",";            
        }            
      }
       resString = resString.TrimEnd(',');     
       array = resString.Split(',').ToArray();
return array;    
}

//Метод печати одномерного массива
void PrintArray( string[] array)
{
    Console.Write("[" + array[0] + ",");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1] + "]");
    Console.WriteLine();
}

int arrayLength = ReadData("Введите длину массива");
string[] array = GenArray(arrayLength);
if (ResultArray(array).Length > 1) 
{
    Console.WriteLine("Итоговый массив с элементами, количество символов в которых <= 3");
    PrintArray(ResultArray(array)); 
}
else
{
    Console.WriteLine("[]");
}
