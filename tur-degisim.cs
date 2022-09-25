

internal class TurDeğişimi
{

    enum NOT

    {
     Başarısız,
     Kaldı,
     Geçer,
     Orta,
     İyi,
     Pekiyi,

    }
    private static void Main(string[] args)
    {

        // tür değişimleri

        //**console her zaman girileni string okur

        //Console.WriteLine ( "1.Sayıyı giriniz: ");
        //string sayi1 = Console.ReadLine();  //30       

        // Console.WriteLine("2. Sayıyı giriniz:" );
        // string sayi2 = Console.ReadLine();  //42

        // string toplam = sayi1 + sayi2;

        // Console.WriteLine ( "Toplam Değer: " + toplam );
        // // sonuç böyle çıkar string okuduğu için ==> Toplam Değer:  3042

        // //********  int.parse >>>>>>>>>  Convert.ToInt32 **************


        //          Console.WriteLine("Yaşınızı rakam ile yazın: ");
        //          int sayi1 = int.Parse (Console.ReadLine ()); //35

        //         Console.WriteLine ("Doğum yılınızın son iki rakamını yazın: ");
        //         int sayi2 = Convert.ToInt32 (Console.ReadLine()); //87

        //         int toplam = sayi1 * sayi2;

        //         Console.WriteLine ("carpımınız: " + toplam );
        //         System.Console.WriteLine("tamam işte integer ve parse bu");


        // // ***********sayısal yapıyı sayısala çevirme**********

        // int toplam = 200;

        // float sonuc = float.Parse(toplam.ToString()) / 56;
        // // to.string ile önce değeri string bir yapıya dönüştürüp ondan sonra floata parse ile dönüştürüyoruz

        // System.Console.WriteLine(sonuc);


        // ****** ENUM ÖRNEK//

        //sabitleri semboller kullanarak saklamak için
        //class ile aynı yapıda olduğu için aynı sırada olmalı

        

    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
