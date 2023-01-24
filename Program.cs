Console.WriteLine("Введите массив строк через пробел: ");
string[] array = Console.ReadLine().Split(' ').ToArray();

string[] newArray = FormArrayThreeChar(array);

PrintArray(newArray);

//Метод формирования массива с длиной символов 3 и меньше
string[] FormArrayThreeChar(string[] array)
{
    int j = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= 3) count++;
    
    string[] newArray = new String[count];
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= 3) newArray[j++] = array[i];
    
    return newArray;
}

//Метод печати одномерного массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write("; " + arr[i]);
    }
    Console.Write("]");
}