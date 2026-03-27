class Penjumlahan
{
    /**
     * method JumlahTigaAngka sebagai generic, menerima tipe data yang fleksibel dengan 3 value yang berbeda
     * Keyword dynamic untuk membuat tipe data menjadi dinamis, dan validasi where T : struct sebagai validasi angka
     */
    public void JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic val1 = a;
        dynamic val2 = b;
        dynamic val3 = c;

        dynamic hasil = val1 + val2 + val3;

        Console.WriteLine("Hasil penjumlahan : " + hasil);
    }
}

class SimpleDataBase<T>
{
    /**
     * Kelas SimpleDataBase juga menerima tipe data yang fleksibel, 
     * diterima melalui constructor dan disimpan kedalam variabel storedData sebagai global variabel 
     * dengan tipe data yang juga general, 
     * disimpan melalui method AddNewData,
     * lalu ditampilkan melalui PrintAllData
     */
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi {storedData[i]} yang disimpan pada {inputDates[i]}");
        }
    }
}

class Program { 

    public static void Main(string[] args)
    {
        // nim = 103082430002
        /**
         * Kelas pj dipanggil di main untuk menjalankan program dengan memanggil generic method JumlahTigaAngka, tipe yang dikirim adalah float dengan value 10f, 30f, 82f sesuai nim
         */
        Penjumlahan pj = new Penjumlahan();
        pj.JumlahTigaAngka<float>(10f, 30f, 82f);

        float nim1 = 10f;
        float nim2 = 30f;
        float nim3 = 82f;
        /**
         * Kelas sd dipanggil di main untuk menjalankan program dengan memanggil generic class SimpleDataBase, tipe yang dikirim adalah string dengan value 10f, 30f, 82f, lalu memanggil method PrintAllData() untuk menampilkan hasil
         */
        SimpleDataBase<float> sd = new SimpleDataBase<float>();
        sd.AddNewData(nim1);
        sd.AddNewData(nim2);
        sd.AddNewData(nim3);
        sd.PrintAllData();
    }
}