using System;

namespace metots
{
    class Program
    {
        static void Main (string[] args)
        {
            string isim = "Murat Can Meltem Aurora";
            
             int result = 1;
             for (int i = 0; i < 5; i++)
             {
                result = result*3;
             }
             Console.WriteLine(result);
           İslemler instance = new İslemler();
           Console.WriteLine(instance.expo(3,4));
           bool sonuc = isim.CheckSpace();
           Console.WriteLine(sonuc);
           if (sonuc)
           {
            Console.WriteLine(isim.RemoveWhiteSpace());
           }
           int [] dizi = {54,3,97,43,8,12};
           dizi.ArrayShort();
           dizi.EkranaYazdir();

           int sayi = 5;
           Console.WriteLine(sayi.isEvenNumber()); 

           Console.WriteLine(isim.GetFirstCharacter());
        }
    }

    class İslemler
    {
        public int expo (int sayi, int üs)
        {
            if(üs <2)
                return sayi;
            return expo(sayi,üs-1)*sayi;
        }
    }
    public static class Extension
    {

        public static bool CheckSpace(this string isim)
        {
            return isim.Contains(" ");
        }

        public static string RemoveWhiteSpace(this string isim)
        {
            string[] dizi = isim.Split(" ");
            return string.Join("*",dizi);
        }
        public static int[] ArrayShort(this int[] dizi)
        {
            Array.Sort(dizi);
            return dizi;
        }

        public static void EkranaYazdir(this int[] yazdir)
        {
            foreach (int item in yazdir)
            {
                Console.WriteLine(item);
            }
        }
        public static bool isEvenNumber (this int param)
        {
            return param%2==0;
        }

        public static string GetFirstCharacter (this string isim)
        {
            return isim.Substring(0,2);
        }
    }
}