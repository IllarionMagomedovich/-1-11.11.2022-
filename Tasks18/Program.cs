// Напишите программу, которая по заданному номеру четверти
// показывает диапозон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти:");
string quarter = Console.ReadLine();
    //Диапозон 
string Range(string quarter1)
{
   if(quarter== "1") return "xc > 0 и yc > 0";
   if(quarter== "2") return "xc < 0 и yc > 0";
   if(quarter== "3") return "xc < 0 и yc < 0";
   if(quarter1== "4") return "xc > 0 и yc < 0";
   return "Введен неверный номер четверти";
}
string range = Range(quarter);

Console.WriteLine(range);