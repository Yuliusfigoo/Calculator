using System;

namespace kalkulator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            double bil1, bil2, pilih;


            Console.WriteLine("Silahkan Pilih Menu Di bawah ini : ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.Write("Masukkan Pilihan [1..4] : ");
            pilih = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            
            if(pilih == 1)
            {
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} + {1} = {2}", bil1, bil2, tambah(bil1, bil2));
            }
            
            else if (pilih == 2)
            {
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} - {1} = {2}", bil1, bil2, kurang(bil1, bil2));
            }

            else if (pilih == 3)
            {
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} * {1} = {2}", bil1, bil2, kali(bil1, bil2));
            }

            else if (pilih == 4)
            {
                Console.Write("Masukkan nilai a = ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hasilnya adalah {0} / {1} = {2}", bil1, bil2, bagi(bil1, bil2));
            }

            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }
        }

        static double tambah(double a, double b)
        {
            return a + b;
        }

        static double kurang(double a, double b)
        {
            return a - b;
        }

        static double kali(double a, double b)
        {
            return a * b;
        }

        static double bagi(double a, double b)
        {
            return a / b;
        }
    }
}