int Find_numbers_more_zero(int count)
{

    string x = "";
    int counter = 0;

    int[] array = new int[count];
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    for (int i = 0; i < array.Length; i++)
    {
    
        if (array[i]>0)
        {
            counter+=1;
        }
        

    }
    x = string.Join(", ", array);


    
    return counter;

}
Console.Write("Введите колличество чисел: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.Write(Find_numbers_more_zero(result));