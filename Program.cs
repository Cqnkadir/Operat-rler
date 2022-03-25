using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****atama ve işlemli atamalar****");
            // atama ve işlemli atamalar
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);

            Console.WriteLine("****İlişkisel Operatörler****");
            //mantıksal Operatörler
            // ||, && !

            bool isSuccess = true;
            bool isCompleted = false;
           
            if(isSuccess && isCompleted)
               Console.WriteLine("Perfect!");
            
            if(isSuccess || isCompleted)
               Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)    
                Console.WriteLine("Fine!");

            Console.WriteLine("****İlişkisel Operatörler****");
            // İlişkisel Operatörler
            // <,> <=, >=, ==,!=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("****Aritmatik Operatörler****");
            // Aritmatik Operatörler
            // /, *,+,-

            int sayı1 = 10;
            int sayı2 = 5;
            int sonuc1 = sayı1/sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1*sayı2;
            Console.WriteLine(sonuc1);    
            sonuc1 = sayı1+sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayı1++;
            Console.WriteLine(sayı1);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2); 

            
        }
    }
}
