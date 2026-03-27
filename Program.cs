class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic val1 = a;
        dynamic val2 = b;
        dynamic val3 = c;

        dynamic hasil = val1 + val2 + val3;

        Console.WriteLine("Hasil penjumlahan : " + hasil);
    }
}

class Program { 

    public static void Main(string[] args)
    {
        // nim = 103082430002
        Penjumlahan pj = new Penjumlahan();
        pj.JumlahTigaAngka<float>(10f, 30f, 82f);
    }
}