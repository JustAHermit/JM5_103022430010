public class PemrosesData{
    public T DapatkanNilaiTerbesar<T> (T nilai1, T nilai2, T nilai3)
    {
        dynamic nil1 = (dynamic)nilai1;
        dynamic nil2 = (dynamic)nilai2;
        dynamic nil3 = (dynamic)nilai3;
        dynamic nilB = nil1;

        if (nil2 > nilB)
        {
            nilB = nil2;
        }

        if (nil3 > nilB)
        {
            nilB = nil3;
        }
        return nilB;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        long nilB = data.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine("Nilai Terbesar Adalah : " + nilB);
    }
}

