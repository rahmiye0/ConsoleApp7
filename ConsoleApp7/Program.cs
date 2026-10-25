Random rd = new Random();
int[] rsayilar = new int[10];

Console.WriteLine("Rastgele sayılarla karşılaştırmak için bir sayı giriniz:");
string girdi = Console.ReadLine();
int sayi;
while (!int.TryParse(girdi, out sayi))
{
    Console.WriteLine("Lütfen geçerli bir sayı giriniz:");
    girdi = Console.ReadLine();
}
for (int i = 0; i < rsayilar.Length; i++)
{
    rsayilar[i] = rd.Next(1, 1000);
    Console.WriteLine( (i+1) + ". sayı :" + rsayilar[i]);
}
int enb = rsayilar[0];
int enk = rsayilar[0];
int sirab = 1;
int sirak = 1;

for (int i = 0; i < rsayilar.Length; i++)
{
    if (rsayilar[i] > enb)
    {
        enb = rsayilar[i];
        sirab = i + 1;
    } 
    if (rsayilar[i] < enk)
    {
        enk = rsayilar[i];
        sirak = i + 1;
    }
}
int csayilar = 0;
int tsayilar = 0;
for (int a= 0; a < 10; a++)
{
    if (rsayilar[a] % 2 == 0)
    {
        csayilar++;
    }
    else
    {
        tsayilar++;
    }
}
for (int i = 0; i < 10; i++)
{
    if(rsayilar[i]> int.Parse(girdi))
    {
        Console.WriteLine(rsayilar[i] + " sayısı girdiğiniz sayıdan büyüktür.");
    }
}

Console.WriteLine("sayılar arasındaki çift sayi adedi: " + csayilar);
Console.WriteLine("sayılar arasındaki tek sayi adedi: " + tsayilar);

Console.WriteLine("En büyük sayı: " + enb + " ve " +sirab + ". sırada");
Console.WriteLine("En küçük sayı: " + enk + " ve " + sirak + ". sırada");

