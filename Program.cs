using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;
            if (sicaklik <= (int)Havadurumu.Normal)
                Console.WriteLine("Dışarı çıkmak için hava biraz ısınmalı.");
            else if (sicaklik >= (int)Havadurumu.Coksicak)
                Console.WriteLine("Dışarı çıkmak için sıcak bir gün.");
            else if (sicaklik >= (int)Havadurumu.Normal && sicaklik <= (int)Havadurumu.Coksicak)
                Console.WriteLine("Dışarı çıkabilirsn.");
        }

        enum Gunler
        {
            Pazartesi=1,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma=25,
            Cumartesi,
            Pazar
        }

        enum Havadurumu
        {
            Soguk = 5,
            Normal=20,
            Sıcak=25,
            Coksicak=30
        
        }
    }
}
