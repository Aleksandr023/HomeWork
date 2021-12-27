
void FillArray(int[] array)
{
    int length= array.Length;
    int index = 0;
    while (index<length)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] newArray)
{
    int count = newArray.Length;
    int position = 0;
    while (position < newArray.Length)
    {
        Console.Write($"{newArray[position]} ");
        position++;
    }
    Console.WriteLine();
}

void Parity(int[] startArray)
{
    int[] finalArray = new int [startArray.Length];
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i] % 2 == 0)
        {            
            finalArray[i] = startArray[i];
            Console.Write(finalArray[i] + " ");                              
        }    
    }   
}

int [] testArray = new int [10];
FillArray(testArray);
PrintArray(testArray);
Parity(testArray);