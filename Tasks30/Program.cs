// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1, 0, 1, 1, 0, 1, 0, 0]

// int[] array = new int[8];

// int[] array = {3, 5, 7, 8};

//    array[0] = 34;
//    array[1] = 36;
//    array[2] = 74;

   int[] array =  new int[8];
   void RandomArray(int [] array)
{
   Random rnd = new  Random();
   for (int i = 0; i < array.Length; i++)
   {
        array[i] = rnd.Next(0, 2);
   }
} 

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
RandomArray(array);
PrintArray(array);