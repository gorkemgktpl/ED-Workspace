using Business.Concrete;
using Entities.Concrete;

Citizen citizen1 = new Citizen();
//Person person1 = new Person();

SayHi("Görkem");
SayHi();

int result = Topla(3, 5);
int result2 = Topla();

// Diziler

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

// Referans tipler -> array, class, interface, abstract, string
// Garbage Collector

// Döngüler

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);

// Değer tipler -> int, double, bool

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
// sayi2 ??
Console.WriteLine(sayi2);

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

// Test

Person person1 = new Person();
person1.NationalID = 123;
person1.FirstName = "GÖRKEM";
person1.LastName = "GÖKTEPELİ";
person1.DateOfBirth = 2001;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

// resharper
static void SayHi(string name = "anonymous")
{
    Console.WriteLine("Hi " + name);
}

static int Topla(int number1 = 5, int number2 = 10)
{
    int result = number1 + number2;
    Console.WriteLine("Sum = " + result.ToString());
    return result;
}

// pascal casing
public class Citizen
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int BirthDate { get; set; }
    public long Id { get; set; }
}