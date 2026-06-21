Console.WriteLine("=== Basit Hesap Makinesi == ");

Console.WriteLine("Birinci Sayiyi gir: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İslem Sec (+, -, *, /):");
string islem = Console.ReadLine() ?? "";

Console.WriteLine("İkinci sayiyi gir: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

double sonuc;

switch (islem)
{
    case "+":
        sonuc = sayi1 + sayi2;
        break;
    case "-":
        sonuc = sayi1 - sayi2;
        break;
    case "*":
        sonuc = sayi1 * sayi2;
        break;
    case "/":
        if (sayi2 == 0)
        {
            Console.WriteLine("Hata: Sifira bolme yapilamaz!");
            return;
        }
        sonuc = sayi1 / sayi2;
        break;
    default: 
        Console.WriteLine("Gecersiz İslem!");
        return;
}
Console.WriteLine($"Sonuc: {sayi1} {islem} {sayi2} = {sonuc}");