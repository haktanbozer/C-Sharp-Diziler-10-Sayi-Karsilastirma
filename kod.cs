using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] sayilar = new float[10];
            float toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Klavyeden {0}. sayıyı girin:", i + 1);
                sayilar[i] = float.Parse(System.Console.ReadLine());
                toplam += sayilar[i];
            }
            float ort = toplam / 10f;
            Console.Write("Girilen 10 Sayinin Ortalamasi = " + ort);
        }
        }
    }
