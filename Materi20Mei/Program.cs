using System;

namespace Materi20Mei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AngkaPertama = 10;
            Console.Write("Input Angka Ke Dua : ");
            int AngkaKedua = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Penjumlahan(AngkaPertama, AngkaKedua));

            string KalimatKu = "Aku adalah anak gembala";
            Console.WriteLine(PotongHurufSatuAtribut(KalimatKu, 5));

        }

        static string PotongHurufSatuAtribut(string Kalimatnya, int JumlahKarakter)
        {
            string HasilAkhir = "";
            int menghitungJumlahYangDipotong = 0;
            foreach (char karakter in Kalimatnya)
            {
                if (menghitungJumlahYangDipotong < JumlahKarakter)
                {
                    menghitungJumlahYangDipotong++;
                }
                else
                {
                    HasilAkhir += karakter;
                }
                
            }
            return HasilAkhir;
        }

        static string PotongHurufDuaAtribut(string Kalimatnya, int Angka1, int Angka2)
        {
            string HasilAkhir = "";
            int menghitungJumlahYangDipotong = 0;
            foreach (char karakter in Kalimatnya)
            {
                if (menghitungJumlahYangDipotong < Angka1)
                {
                    menghitungJumlahYangDipotong++;
                }
                else
                {
                    HasilAkhir += karakter;
                }

            }
            return HasilAkhir;
        }


        static int Penjumlahan(int Angka1, int Angka2)
        {
            return Angka1 + Angka2;
        }

    }
}
