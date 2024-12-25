using System;
using System.Transactions;

class Program
{
    static void Main()
    {
        Sarki();
        Console.WriteLine("sayının bölümünden kalan: "+Mod());
        Console.WriteLine("çarpım: "+Carpim(5, 10)); 
        bilgi("Gamze", "BİLGE");
    }

    static void Sarki()
    {
        Console.WriteLine("aaaaaa");
    }

    static int Mod()
    {
        Random random = new Random();
        int rastgeleSayi = random.Next();
        Console.WriteLine("rastgele sayı :" +rastgeleSayi);

        return rastgeleSayi % 2;
       
    }

    static int Carpim( int x , int y)
    {
        return x * y;
    }

    static void bilgi(string isim , string soyisim)
    {
        Console.WriteLine($"Hoşgeldiniz {isim} {soyisim}");
    }
}