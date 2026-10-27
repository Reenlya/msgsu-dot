Random rnd = new Random();
int[] rastgeleSayilar = new int[10];

for (int i = 0; i < rastgeleSayilar.Length; i++)
{
    rastgeleSayilar[i] = rnd.Next(0, 100);
    Console.WriteLine("Rastgele " + (i + 1) + ". sayı: " + rastgeleSayilar[i]);
}

int enb = rastgeleSayilar[0];
int enk = rastgeleSayilar[0];
int a = 1;
int c = 1;
int kacinciSayi = 0;
int kacinciSayi2 = 0;

foreach (int sayi in rastgeleSayilar)
{
    if (sayi > enb)
    {
        enb = sayi;
        kacinciSayi = a;
    }
    if (sayi < enk)
    {
        enk = sayi;
        kacinciSayi2 = c;
    }
    a++;
    c++;
}

Console.WriteLine("Değerler arasında en büyük sayı " + enb.ToString());
Console.WriteLine("Değerler arasında en büyük sayının giriş sırası " + kacinciSayi.ToString());

Console.WriteLine("Değerler arasında en küçük sayı " + enk.ToString());
Console.WriteLine("Değerler arasında en büyük sayının giriş sırası " + kacinciSayi2.ToString());

int cs = 0;
int ts = 0;

foreach (int ct in rastgeleSayilar)
{
    if ((ct % 2) < 1)
    {
        cs++;
    }
    else
    {
        ts++;
    }
}

Console.WriteLine("Toplam Çift Sayıların adedi: " + cs);
Console.WriteLine("Toplam Tek Sayıların adedi: " + ts);

Console.WriteLine("Lütfen bir sayı giriniz:");
int deger;
while (!int.TryParse(Console.ReadLine(), out deger))
{
    Console.WriteLine("Lütfen sadece rakamla sayı girin");
}

Console.WriteLine("Girdiğiniz (" + deger + ") sayıdan büyük olan rastgele sayılar:");

bool test = false;

foreach (int sayi in rastgeleSayilar)
{
    if (deger < sayi)
    {
        Console.WriteLine(sayi + " sayısı girdiğiniz sayıdan büyüktür");
        test = true;
    }
}

if (!test)
{
    Console.WriteLine("Girdiğiniz sayıdan büyük bir sayı bulunmamakta");
}

/*deneme*/