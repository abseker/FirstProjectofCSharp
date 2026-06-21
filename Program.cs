// Değişken tanımlama 
string isim = "Berk";
int yas = 24;

// Console.WriteLine ekrana yazdırır
Console.WriteLine($"Merhaba. {isim}! Yaşin: {yas}");

// Kullanıcıdan girdi almak
Console.WriteLine("Adini gir: ");
string kullaniciAdi = Console.ReadLine() ?? "";

Console.WriteLine($"Hoş Geldin, {kullaniciAdi}!");