// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либа равна трем символам. 

void FillArray(string [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=Console.ReadLine() ?? "0";
    }
}
void PrintArray (string [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine("введите элементы массива:");
string[] array = new string[5];
FillArray(array);
Console.WriteLine("ваш массив:");
PrintArray(array);
Console.WriteLine();

int index=1;
int j=0;

for (int i=0; i<array.Length; i++)
{
    if (array[i].Length <=3)
        index=index+1;  
}

string[] array1 = new string[index];
for (int i=0; i<array.Length; i++)
{
    if (array[i].Length <=3)
    {
        array1[j]=array[i];
        j=j+1;
    } 
}
Console.WriteLine("новый массив:");
for (int i=0; i<array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
