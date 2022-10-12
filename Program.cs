// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine (a);

int b = a%100;
int c1= b%10;
int d1 = b/10;

while(a>99)
{
    a=a/10;
}
int c2= a/10;
int d2 = a%10;

if (c1==c2 && d1==d2)
{
Console.WriteLine ("Это полиндром!");
}
else Console.WriteLine ("Это не полиндром!");

