
List<string> objeler = new List<string>() { "tas", "kagit", "makas" };

Boolean ObjeSectiMi = false;
int tur = 0;
string girilen = "";
int bilgisayarKazanmaAdeti = 0;
int kullaniciKazanmaAdeti = 0;

List<string> turGecmisi = new List<string>();

Console.WriteLine("Taş Kağıt Makas Oyunu!");

while (true)
{
    ObjeSectiMi = false;
    do
    {
        Console.Write("hangisini seçiyorsun?: ");
        girilen = Console.ReadLine();

        if (girilen.ToLower() == "bitti")
        {
            break;
        }

        for (int i = 0; i < objeler.Count; i++)
        {
            if (girilen.ToLower() == objeler[i].ToLower())
            {
                ObjeSectiMi = true;
                break;
            }
        }

        if (ObjeSectiMi == false)
        {
            Console.WriteLine("Lütfen taş, kağıt, makas dan birini yazın.");
        }
    } while (ObjeSectiMi == false);

    if (ObjeSectiMi == false)
    {
        break;
    }
    tur += 1;

    int rastgeleSayi = Random.Shared.Next(0, objeler.Count);
    string bilgisayarSecimi = objeler[rastgeleSayi];
    Console.WriteLine("Bilgisayarın seçimi : " + bilgisayarSecimi);

    string sonucMesaji = "";

    if (bilgisayarSecimi.ToLower() == girilen.ToLower())
    {
        sonucMesaji = tur + ". Tur: berabere ";
        Console.WriteLine("berabere");
    }
    else
    {
        bool kullaniciKazandiMi = false;

        for (int i = 0; i < objeler.Count; i++)
        {
            if ((girilen.ToLower() == "tas" && bilgisayarSecimi.ToLower() == "makas") || (girilen.ToLower() == "makas" && bilgisayarSecimi.ToLower() == "kagit") || (girilen.ToLower() == "kagit" && bilgisayarSecimi.ToLower() == "tas"))
            {
                kullaniciKazandiMi = true;
                break;
            }
        }

        if (kullaniciKazandiMi)
        {
            Console.WriteLine("kullanıcı kazandı");
            kullaniciKazanmaAdeti++;
            sonucMesaji = tur + ". Tur: kullanıcı kazandı (Seçiminiz: " + girilen + " - Bilgisayar: " + bilgisayarSecimi + ")";
        }
        else
        {
            Console.WriteLine("bilgisayar kazandı");
            bilgisayarKazanmaAdeti++;
            sonucMesaji = tur + ". Tur: Bilgisayar kazandı (Seçiminiz: " + girilen + " - Bilgisayar: " + bilgisayarSecimi + ")";
        }
    }

    turGecmisi.Add(sonucMesaji);
}

Console.WriteLine("OYUN BİTTİ");
Console.WriteLine("Oyun kaç kere oynandı: " + tur.ToString());
Console.WriteLine("Oyuncu kazanma sayısı: " + kullaniciKazanmaAdeti.ToString());
Console.WriteLine("Bilgisayar kazanma sayısı: " + bilgisayarKazanmaAdeti.ToString());

Console.WriteLine("TUR GEÇMİŞİ");
foreach (string gecmis in turGecmisi)
{
    Console.WriteLine(gecmis);
}