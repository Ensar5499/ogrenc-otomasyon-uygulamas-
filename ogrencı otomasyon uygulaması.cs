using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        var hoca1 = new Hoca("Ali", "Yılmaz", "Matematik");
        var ogrenci1 = new Ogrenci("Ayşe", "Demir", 1);
        var ogrenci2 = new Ogrenci("Mehmet", "Kaya", 2);
        var sinif1 = new Sinif("1A", hoca1);

        sinif1.Ogrenciler.Add(ogrenci1);
        sinif1.Ogrenciler.Add(ogrenci2);

        
        sinif1.DersProgrami.Add("Pazartesi", "Matematik");
        sinif1.DersProgrami.Add("Salı", "Fizik");
        sinif1.DersProgrami.Add("Çarşamba", "Kimya");
        sinif1.DersProgrami.Add("Perşembe", "Biyoloji");
        sinif1.DersProgrami.Add("Cuma", "Türkçe");

       
        Console.WriteLine("Hoca (1) / Öğrenci (2) / Sınıf (3) seçin: ");
        var secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                Console.WriteLine($"Hoca: {hoca1.Adi} {hoca1.Soyadi}, Ders: {hoca1.Ders}");
                break;
            case "2":
                foreach (var ogrenci in sinif1.Ogrenciler)
                {
                    Console.WriteLine($"Öğrenci: {ogrenci.Adi} {ogrenci.Soyadi}, Numara: {ogrenci.Numara}");
                }
                break;
            case "3":
                Console.WriteLine($"Sınıf: {sinif1.Isim}, Hoca: {sinif1.Hoca.Adi} {sinif1.Hoca.Soyadi}");
                Console.WriteLine("Ders Programı:");
                foreach (var ders in sinif1.DersProgrami)
                {
                    Console.WriteLine($"{ders.Key}: {ders.Value}");
                }
                Console.WriteLine($"Toplam Ders Sayısı: {sinif1.DersProgrami.Count}");
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }
}

class Hoca
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string Ders { get; set; }

    public Hoca(string adi, string soyadi, string ders)
    {
        Adi = adi;
        Soyadi = soyadi;
        Ders = ders;
    }
}

class Ogrenci
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public int Numara { get; set; }

    public Ogrenci(string adi, string soyadi, int numara)
    {
        Adi = adi;
        Soyadi = soyadi;
        Numara = numara;
    }
}

class Sinif
{
    public string Isim { get; set; }
    public Hoca Hoca { get; set; }
    public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    public Dictionary<string, string> DersProgrami { get; set; } = new Dictionary<string, string>();

    public Sinif(string isim, Hoca hoca)
    {
        Isim = isim;
        Hoca = hoca;
    }
}