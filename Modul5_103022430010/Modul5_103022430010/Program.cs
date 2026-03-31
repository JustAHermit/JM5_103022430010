class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T Data) {
        storedData.Add(Data);
        DateTime currentTime = DateTime.Now;
        inputDates.Add(currentTime);
    }
    public void PrintAllData() 
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisis: " +  storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.AddNewData(10);
        data.AddNewData(30);
        data.AddNewData(22);
        data.PrintAllData();
    }
}

/*public class PemrosesData{
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
}*/

