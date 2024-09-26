using System;
using System.Collections.Generic;

public abstract class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public abstract string Suara();
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur}, Suara: {Suara()}";
    }
}

public abstract class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override abstract string Suara();

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Reptil bersuara...";
    }

    public override string InfoHewan()
    {
        return $"{base.InfoHewan()}, Panjang Tubuh: {PanjangTubuh} meter";
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaum!");
    }

    public override string Suara()
    {
        return "Aum!";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Trumpet!";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap!");
    }

    public override string Suara()
    {
        return "Sss!";
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "HAAAAA";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Simba", 5, 4);
        Gajah gajah = new Gajah("Dumbo", 10, 4);
        Ular ular = new Ular("Kaa", 3, 2.5);
        Buaya buaya = new Buaya("Gena", 7, 4.2);
        Reptil reptil = new Buaya("Gena", 7, 4.2);
        Console.WriteLine(reptil.Suara());


        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        singa.Mengaum();
        ular.Merayap();
    }
}
