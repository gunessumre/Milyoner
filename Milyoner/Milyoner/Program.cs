#region kim milyoner olmak ister

int yanlisCevapSayi = 0;

Console.WriteLine("***** Kim Milyoner Olmak ister*****");
Console.WriteLine("Sorulara Cevaplarinizi Giriniz");
Console.WriteLine("Soru1:Kızınca tüküren hayvan hangisidir?");
Console.WriteLine("a)Lama  b)Deve");
Console.Write("cevap:");
string cevap1 = (Console.ReadLine()).ToLower();


if (cevap1 != "a")
{
    yanlisCevapSayi++;
    Console.WriteLine("Yanlis Cevap Verdiniz ");
}
else
{
    Console.WriteLine("Dogru Cevap Verdiniz!");
}
Console.WriteLine($"Yanlis Cevap Sayisi: {yanlisCevapSayi}");
Console.WriteLine("Soru2: Dünya'ya en yakın gezegen hangisidir? ");
Console.WriteLine(" a) Venüs b) Mars ");
Console.Write("cevabiniz:");
string cevap2 = (Console.ReadLine()).ToLower();

if (cevap2  != "a" )
{
    yanlisCevapSayi++;
    Console.WriteLine("Yanlis Cevap Verdiniz ");
}

else
{
    Console.WriteLine("Dogru Cevabin Verdiniz!");
}

if (yanlisCevapSayi == 2)
{
    Console.WriteLine("Kaybettiniz");
    return;
}

Console.WriteLine("Soru3:5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
Console.WriteLine("a) 7 b) 12 ");
Console.Write("cevabiniz:");
string cevap3 = (Console.ReadLine()).ToLower();

if (cevap3 != "b")
{
    yanlisCevapSayi++;
    Console.WriteLine("Yanlis Cevap Verdiniz ");
}
else
{
    Console.WriteLine("Dogru Cevabin Verdiniz!");
}

if (yanlisCevapSayi < 2)
{
    Console.WriteLine("1 Milyon TL'lik büyük ödülü Kazandiniz");
}



#endregion