// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространствею

// A(3,6,8); B(2,1,-7), = 15.84
// A(7,-5,0); B(1,-1,9) = 11.53
Console.WriteLine("Введите точку XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку XC: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку YC: ");
int yc = Convert.ToInt32(Console.ReadLine());


double Distance (int xa, int ya, int xb, int yb, int xc, int yc )
 {
    double xz = (xa - xb) * (xa - xb);
    double yz = (ya - yb) * (ya - yb);
    double zz = (xc - yc) * (xc - yc);
    double result = Math.Sqrt(xz + yz + zz );
    return result; 
 }
 double res = Distance(xa, ya, xb, yb, xc, yc);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);
