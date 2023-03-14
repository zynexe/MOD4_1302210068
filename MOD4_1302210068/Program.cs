// See https://aka.ms/new-console-template for more information
public class kodeBuah
{
    public Dictionary<string, string> kodebuah = new Dictionary<string, string>()
    {
        {"Apel","A00"},
        {"Aprikot","B00"},
        {"Alpukat","C00"},
        {"Pisang","D00"},
        {"Paprika","E00"},
        {"Kurma","K00"},
        {"Durian","L00"},
        {"Anggur","M00"},
        {"Melon","N00"},
        {"Semangka","O00"}

    };

    public string getKodeBuah(string buah)
    {
        if (kodebuah.ContainsKey(buah))
        {
            return kodebuah[buah];
        }
        else
        {
            return "Kode buah tidak ditemukan";
        }
    }


}



class Program
{
    static void Main(string[] args)
    {
        kodeBuah kodeBuah = new kodeBuah();
        Console.WriteLine("Kode buah Apel: " + kodeBuah.getKodeBuah("Apel"));
        Console.WriteLine("Kode buah Aprikot: " + kodeBuah.getKodeBuah("Aprikot"));
        Console.WriteLine("Kode buah Alpukat: " + kodeBuah.getKodeBuah("Alpukat"));
        Console.WriteLine("Kode buah Semangka: " + kodeBuah.getKodeBuah("Semangka"));
        Console.WriteLine("Kode buah Piscok: " + kodeBuah.getKodeBuah("PisCok"));
        
    }
    
}



