using System.Configuration.Assemblies;

public class HelloWorld
{
    String halo = "halo";
    int angkaSatu;
    int angkaDua;

    public void fungsiDalamKelas()
    {
        String haloJuga = "haloo";
    }

    public void operasiaTambah(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaDuaPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Tambah: " + (angkaSatuPar + angkaDuaPar));

    }

     public void operasiKurang(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaDuaPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Kurang: " +(angkaSatuPar - angkaDuaPar));

    }

     public void operasiKali(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaDuaPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Perkalian: " + (angkaSatuPar * angkaDuaPar));

    }

     public void operasiBagi(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaDuaPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Pembagian: " + (angkaSatuPar / angkaDuaPar));

    }


    
    public static void Main()
    {
        Console.WriteLine("Merdeka");
        HelloWorld inisiasiHello = new HelloWorld();

        Console.WriteLine(inisiasiHello.halo);

        inisiasiHello.fungsiDalamKelas();

        inisiasiHello.operasiaTambah(2,1);
        inisiasiHello.operasiKurang(4, 2);
        inisiasiHello.operasiKali(3, 2);
        inisiasiHello.operasiBagi(4, 2);
    }
    
}
