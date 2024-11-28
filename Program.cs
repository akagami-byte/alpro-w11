using System;
using System.Linq;

namespace Tugas11;
#nullable disable

class Urutsiswa 
{
    static string[] Nama = {"Divan", "Joko", "Ngedi", "Tomi", "Sinta"};
    static int[] Nilai = {90, 75, 87, 90, 93};

    public static void RerataSiswa()
    {
        Console.WriteLine();
        int sum = Nilai.Sum();
        int average = sum / Nilai.Length;
        Console.WriteLine($"Nilai Rata - Rata: {average}");
    }

    public static void DataMhs()
    {
        Console.WriteLine();
        for (int i = 0; i < Nama.Length; i++)
        {
            Console.WriteLine($"Nama: {Nama[i]}, Nilai: {Nilai[i]}");
        }
    }

    public static void MaxMinNilai()
    {
        Console.WriteLine();
        // Finding max
        int Max = Nilai.Max();
        // Positioning max
        int Pmax = Array.IndexOf(Nilai, Max);
        Console.WriteLine($"Nilai Tertinggi: {Max}, {Nama[Pmax]}");
        // Finding min
        int Min = Nilai.Min();
        // Positioning min
        int Pmin = Array.IndexOf(Nilai, Min);
        Console.WriteLine($"Nilai Tertinggi: {Min}, {Nama[Pmin]}");
    }

    string OpsiPilih()
    {
        Console.WriteLine("\nPilih Menu: ");
        Console.WriteLine("1. Tampilkan semua data Mahasiswa: ");
        Console.WriteLine("Tampilan Nilai tertinggi dan Terendah: ");
        Console.WriteLine("3. Hitung Rata - rata Nilai: ");
        Console.WriteLine("4. Tampilkan data mahasiswa berdasarkan nilai (descending): ");
        Console.Write("5. Keluar  ");
        return Console.ReadLine();
    }

    static void Main()
        {
            Urutsiswa Pilihan = new Urutsiswa();
            string Pilih;
            do{
                Pilih = Pilihan.OpsiPilih();
                if (Pilih == "1"){
                    DataMhs();
                }
                if (Pilih == "2"){
                    MaxMinNilai();
                }
                if (Pilih == "3"){
                    RerataSiswa();
                }
                else{
                    Console.WriteLine("Tidak ada angka ");
                }
            }
            while (Pilih != "5");
        // MaxMinNilai();1
        // DataMhs();
        // RerataSiswa();
        }

}


