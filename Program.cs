// Dolu Kare
// * * *
// * * *
// * * *


Console.Write("Rakam giriniz: ");
int rakam = int.Parse(Console.ReadLine());

for (int i = 1; i <= rakam; i++)
{
    for (int j = 1; j <= rakam; j++)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}


Console.WriteLine("----------------------");

// Dik Kenar Ucgeni
// *
// * *
// * * *

Console.WriteLine("Rakam giriniz: ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}



Console.WriteLine("----------------------");

// Ici Bos Kare
// * * * *
// *     *
// *     *
// * * * *

Console.Write("Yüksekliği Girin : ");
int yukseklik = int.Parse(Console.ReadLine());

for (int i = 1; i <= yukseklik; i++)
{
    for (int j = 1; j <= yukseklik; j++)
    {
        if (i == 1 || i == yukseklik) Console.Write(" *");
        else if (j == 1 || j == yukseklik) Console.Write(" *");
        else Console.Write("  ");
    }
    Console.WriteLine();
}
Console.WriteLine();


// Carpim Tablosu

Console.WriteLine("----------------------");

for (int i = 1;i <= 10; i++)
{
    for(int j=1; j <=10; j++)
    {
        Console.Write("{0}*{1}={2}\t",j,i,(j * i));
    }
        Console.WriteLine();
}


// 1-100 arasi sade ededler

Console.WriteLine("----------------------");

int sade;
for (int i = 2; i <= 100; i++)
{
    sade = 0;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            sade++;
        }
    }
    if (sade == 0) Console.WriteLine(i);
}


// A-Z ye alfabeyi yazdirmak
// char a;
// for(a = 'A'; a <= 'Z'; ++a)
// {
//     Console.WriteLine(a);
// }


// for ve foreach 0-1000 cift
//for(int i = 2; i <= 1000; i+=2)
//{
//    Console.WriteLine(i);
//}

//foreach (int say in Enumerable.Range(0, 1001))
//{
//    if (say % 2 == 0) Console.WriteLine(say);
//}


// Ededin ikinin ustu olub olmadigini tapin
// Ededin mertebeliyini console-a yazdirin (ex: 322-3,2200-4)

//Console.Write("Eded girin:");
//int number = int.Parse(Console.ReadLine());
//for(int i = 0; number%10 == 0; i++)
//{
//    number = number / 2;
//}

//if (number == 1) Console.WriteLine(true);
//else Console.WriteLine(false);

//Console.Write("Sayi Giriniz: ");
//int sayi = int.Parse(Console.ReadLine());
//int mertebe = 0;
//for(int i = 1; i <= sayi; i++)   // while(sayi != 0)
//{
//    sayi /= 10;
//    mertebe++;
//}

//Console.WriteLine(mertebe);

// for(i=num;i>=1;i/=10  )
// step +=1