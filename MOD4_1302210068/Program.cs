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

class posisiGameKarakter
{
    private State currentstate;

    public posisiGameKarakter()
    {
        currentstate = new Berdiri();
        Console.WriteLine("Posisi Berdiri");
    }

    public void SetState(State state)
    {
        currentstate = state;
        currentstate.Display();
    }

    public void Tombolw()
    {
        currentstate.TombolW(this);
    }
    public void Tombolk()
    {
        currentstate.Tombolk(this);
    }
}

abstract class State
{
    public abstract void TombolW(posisiGameKarakter posisi);
    public abstract void Tombolk(posisiGameKarakter posisi);
    public abstract void Display();
}

class Berdiri : State
{
    public override void TombolW(posisiGameKarakter posisi)
    {
        Console.WriteLine("Posisi Take off");
    }

    public override void Tombolk(posisiGameKarakter posisi)
    {
        Console.WriteLine("Posisi Take off");
    }
    public override void Display()
    {
        Console.WriteLine("Posisi Take off");
    }



}

class Terbang : State
{
    public override void Tombolk(posisiGameKarakter posisi)
    {
        Console.WriteLine("Posisi Landing");
    }

    public override void TombolW(posisiGameKarakter posisi)
    {
        Console.WriteLine("");
    }

    public override void Display()
    {
        Console.WriteLine("Posisi Landing");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------NO 1------");
        kodeBuah kodeBuah = new kodeBuah();
        Console.WriteLine("Kode buah Apel: " + kodeBuah.getKodeBuah("Apel"));
        Console.WriteLine("Kode buah Aprikot: " + kodeBuah.getKodeBuah("Aprikot"));
        Console.WriteLine("Kode buah Alpukat: " + kodeBuah.getKodeBuah("Alpukat"));
        Console.WriteLine("Kode buah Pisang: " + kodeBuah.getKodeBuah("Pisang"));
        Console.WriteLine("Kode buah Paprika: " + kodeBuah.getKodeBuah("Paprika"));
        Console.WriteLine("Kode buah Kurma: " + kodeBuah.getKodeBuah("Kurma"));
        Console.WriteLine("Kode buah Durian: " + kodeBuah.getKodeBuah("Durian"));
        Console.WriteLine("Kode buah Anggur: " + kodeBuah.getKodeBuah("Anggur"));
        Console.WriteLine("Kode buah Melon: " + kodeBuah.getKodeBuah("Melon"));

        Console.WriteLine("Kode buah Semangka: " + kodeBuah.getKodeBuah("Semangka"));
        Console.WriteLine("Kode buah Piscok: " + kodeBuah.getKodeBuah("PisCok"));

        Console.WriteLine("-------NO 2-------");
        posisiGameKarakter posisi = new posisiGameKarakter();
        posisi.Tombolk();
        posisi.SetState(new Terbang());
        posisi.Tombolw();


    }
    
}



