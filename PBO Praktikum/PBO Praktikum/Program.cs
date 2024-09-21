public abstract class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

public abstract class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki)
    : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

public abstract class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh)
        : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }
    public override string Suara()
    {
        return "AAAUUUMMMM";
    }
    public string Mengaum()
    {
        return "Singa lagi mengaum";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }
    public override string Suara()
    {
        return "EEEKKKKKK";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }
    public override string Suara()
    {
        return "TSSSSST";
    }
    public string Merayap()
    {
        return "Jalan Ular Merayap Seperti Cicak";
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }
    public override string Suara()
    {
        return "GRRRRRR";
    }
}

public class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (Hewan hewan in koleksiHewan)
        {
            Console.WriteLine($"Nama: {hewan.Nama}, Umur: {hewan.Umur}, Suara: {hewan.Suara()}");
        }
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {

//        //KebunBinatang kebunBinatang = new KebunBinatang();

//        //Singa singa = new Singa("Sapi", 5, 4);
//        //Gajah gajah = new Gajah("Ganji", 10, 4);
//        //Ular ular = new Ular("Sari", 3, 1.5);
//        //Buaya buaya = new Buaya("Crico", 8, 2.0);

//        //kebunBinatang.TambahHewan(singa);
//        //kebunBinatang.TambahHewan(gajah);
//        //kebunBinatang.TambahHewan(ular);
//        //kebunBinatang.TambahHewan(buaya);

//        //kebunBinatang.DaftarHewan();

//        //Console.WriteLine("Polymorphism:");
//        //Console.WriteLine(singa.Suara());
//        //Console.WriteLine(gajah.Suara());
//        //Console.WriteLine(ular.Suara());
//        //Console.WriteLine(buaya.Suara());


//        //Console.WriteLine("Demonstrating special methods:");
//        //Console.WriteLine(singa.Mengaum()); 
//        //Console.WriteLine(ular.Merayap()); 
//    }
//}

//Analisis Percobaan 1 & 2
//public class Program
//{
//    public static void Main(string[] args)
//    {

//        Gajah gajah = new Gajah("Ganesha", 10, 4);
//        Ular ular = new Ular("Siska", 3, 1.5);
//        Singa singa = new Singa("Simba", 5, 4);

//        Console.WriteLine(gajah.Suara()); 
//        Console.WriteLine(ular.Suara());
//        Console.WriteLine(singa.Mengaum());
//    }
//}

//Analisis Percobaan 3
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        KebunBinatang kebunBinatang = new KebunBinatang();

//        Singa singa = new Singa("Simba", 5, 4);
//        kebunBinatang.TambahHewan(singa);

//        kebunBinatang.DaftarHewan();
//    }
//}

//Analisis Percobaan 4
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Ular ular = new Ular("Kobra", 5, 10.5);

//        Console.WriteLine(ular.Merayap());
//    }
//}

//Analisis Percobaan 4
public class Program
{
    public static void Main(string[] args)
    {
        Reptil reptil;

        reptil = new Buaya("Bajol", 10, 5.0);

        Console.WriteLine(reptil.Suara());
    }
}