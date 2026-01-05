using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;

            for (int i = 2; i <= n; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> seri = new List<int>();

            if (adet <= 0) return seri;

            seri.Add(0);
            if (adet == 1) return seri;

            seri.Add(1);

            int i = 2;
            while (i < adet)
            {
                int sonSayi = seri[i - 1];
                int oncekiSayi = seri[i - 2];
                seri.Add(sonSayi + oncekiSayi);
                
                i++;
            }

            return seri;
        }

        public static int BasamakSayisi(int sayi)
        {
            int basamak = 0;
            
            if (sayi < 0) sayi = -sayi; 

            do
            {
                sayi /= 10;
                basamak++;
            } while (sayi > 0); 

            return basamak;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }

        public static int SayilarinToplami(int n)
        {
            int toplam = 0;

            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }

            return toplam;
        }
    }
}
