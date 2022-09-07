/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> дa
23432 -> да

void palindrom(int num){
        string numberTxt = Convert.ToString(num);
        if (numberTxt[0] == numberTxt[4] || numberTxt[1] == numberTxt[3]){
        Console.WriteLine("Введенное число является палиндромом.");
        }
            else Console.WriteLine("Введенное число не является палиндромом");

            if (numberTxt.Length != 5){
                        Console.WriteLine("Введите пятизначное число ");
            }
}

Console.WriteLine("Введи число и побыстрее!!!");
int num = Convert.ToInt32(Console.ReadLine());
palindrom(num);
*/

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53




double space (double x1, double y1, double z1, double x2, double y2, double z2){
      return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    
}

Console.WriteLine("Введи координаты первой точки x1,y1,z1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи координаты второй точки x2,y2,z2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double result =  Math.Round (space(x1, y1, z1, x2, y2, z2), 2 );

Console.WriteLine("Расстояние между двумя точками в пространстве - " + result);



Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void cub(int n){
    int first = 1;
    while (first <= n){
        Console.WriteLine(first*first*first + ",");
        first++;
    }
}

Console.WriteLine("Введи число и побыстрее!!!");
int umberTxt = Convert.ToInt32(Console.ReadLine());
cub(umberTxt);
