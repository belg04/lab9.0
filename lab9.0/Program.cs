using System;
// Лукьянов глеб  бфзовый уровень 9 лаба
namespace MyApp 
{
    
    class coin
    {
        public int nominal;
        public int quantity;
        public int total;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           coin c1 = new coin();
            c1.nominal = 1;
            c1.quantity = 5;
            c1.total = 5;


            coin c2 = new coin();
            c2.nominal = 2;
            c2.quantity = 2;
            c2.total = 4;


            coin c5 = new coin();
            c5.nominal = 1;
            c5.quantity = 5;
            c5.total = 5;


            coin c10 = new coin();
            c10.nominal = 3;
            c10.quantity = 10;
            c10.total = 30;

            Console.WriteLine("Данные из c1:");
            Console.WriteLine("Номинал: " + c1.nominal);
            Console.WriteLine("Количество: " + c1.quantity);
            Console.WriteLine("Итого: " + c1.total);

            Console.WriteLine("\nДанные из c2:");
            Console.WriteLine("Номинал: " + c2.nominal);
            Console.WriteLine("Количество: " + c2.quantity);
            Console.WriteLine("Итого: " + c2.total);

            Console.WriteLine("\nДанные из c5:");
            Console.WriteLine("Номинал: " + c5.nominal);
            Console.WriteLine("Количество: " + c5.quantity);
            Console.WriteLine("Итого: " + c5.total);

            Console.WriteLine("\nДанные из c10:");
            Console.WriteLine("Номинал: " + c10.nominal);
            Console.WriteLine("Количество: " + c10.quantity);
            Console.WriteLine("Итого: " + c10.total);

        }
    }
}