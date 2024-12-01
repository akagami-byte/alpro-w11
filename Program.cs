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
        int sum = Nilai.Sum(); //pake library Linq tinggal panggil Array.Sum untuk jumlah
        int average = sum / Nilai.Length; //buat variable baru untuk mendefinisikan Jumlah / banyak angka (5)
        Console.WriteLine($"Nilai Rata - Rata: {average}");
    }

    public static void DataMhs()
    {
        Console.WriteLine();
        for (int i = 0; i < Nama.Length; i++) //print selama i < panjang array
        {
            Console.WriteLine($"Nama: {Nama[i]}, Nilai: {Nilai[i]}");
        }
    }

    public static void MaxMinNilai()
    {
        Console.WriteLine();
        // Cari nilai max
        int Max = Nilai.Max(); //pake library linq
        //  Cari value yang bernilai max
        int Pmax = Array.IndexOf(Nilai, Max);
        Console.WriteLine($"Nilai Tertinggi: {Max}, {Nama[Pmax]}");
        // cari nilai min
        int Min = Nilai.Min();
        // Cari value yang bernilai min
        int Pmin = Array.IndexOf(Nilai, Min);
        Console.WriteLine($"Nilai Terendah: {Min}, {Nama[Pmin]}");
    }

    public static void DescendFunc(){
        Array.Sort(Nilai);
        Array.Reverse(Nilai);
        Console.WriteLine("\n Nilai Tertinggi ke terendah (descending)");
        for (int i = 0; i < Nama.Length; i++)
        {
            Console.Write($"{Nilai[i]} ");
        }
        Console.WriteLine("");
    }



    string OpsiPilih()
    {
        Console.WriteLine("\n==========Pilih Opsi========== ");
        Console.WriteLine("1. Tampilkan semua data Mahasiswa: ");
        Console.WriteLine("2. Tampilan Nilai tertinggi dan Terendah: ");
        Console.WriteLine("3. Hitung Rata - rata Nilai: ");
        Console.WriteLine("4. Tampilkan data mahasiswa berdasarkan nilai (descending): ");
        Console.WriteLine("5. Keluar  \n");
        Console.Write("Masukkan angka sesuai Opsi: ");
        return Console.ReadLine();
    }

    static void Main(string[] args)
        {
            Urutsiswa Pilihan = new Urutsiswa();
            string Pilih;
            do{
                Pilih = Pilihan.OpsiPilih();
                if (Pilih == "1"){
                    DataMhs();
                }
                else if (Pilih == "2"){
                    MaxMinNilai();
                }
                else if (Pilih == "3"){
                    RerataSiswa();
                }
                else if (Pilih == "4"){
                    DescendFunc();
                }
                
            }
            while (Pilih != "5");
        // MaxMinNilai();
        // DataMhs();
        // RerataSiswa();
        }

}


