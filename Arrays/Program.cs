using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List, birden fazla değeri saklayabilen bir veri yapısıdır.
        // List içerisinde farklı veri tiplerini tutabilirsiniz.

        List<object> hayvanlar = new List<object>();
        hayvanlar.Add("Köpek");
        hayvanlar.Add("Kedi");
        hayvanlar.Add(10);

        // Ekrana List'in kaç tane eleman içerdiğini yazar.
        Console.WriteLine(hayvanlar.Count);

        // List içindeki belirli bir indeksteki elemanı siler.
        hayvanlar.RemoveAt(0);

        // List içindeki tüm elemanları siler.
        hayvanlar.Clear();

        // List içinde belirli bir indeksteki elemanı değiştirir.
        hayvanlar.Insert(0, "balık");

        // List'ı farklı veri tipleri ile tanımlayabilirsiniz.
        List<object> evcilHayvanlar = new List<object>();
        evcilHayvanlar.Add("Köpek");
        evcilHayvanlar.Add("Kedi");

        // List içinde sadece belirli bir veri tipini saklamak için tür belirtilebilir.
        List<int> dogumTarihi = new List<int>();
        dogumTarihi.Add(2003);
        dogumTarihi.Add(2005);

        // String dizisi oluşturmak için:
        string[] isimler = { "Sude", "Mustafa", "Ebru", "Asiye" };

        // Integer dizisi oluşturmak için:
        int[] yaslar = { 20, 15, 30 };
    }
}
