// See https://aka.ms/new-console-template for more information


//Dizi Tanımlama
string[] renkler = new string[5];

string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

int[] dizi;
dizi = new int [5];

//Dizilere Değer Atama ve Erişim
renkler[0] ="Mavi";
dizi[3] = 10;

System.Console.WriteLine(hayvanlar[1]);
System.Console.WriteLine(dizi[3]);
System.Console.WriteLine(renkler[0]);

// Döngüler dizi kullanımı
//Klavyeden girilen n tane sayının ortalamasını hesaplayan program

System.Console.WriteLine("Lütfen dizinin eleman sayisini giriniz");
int diziUzunluğu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunluğu];

for (int i = 0; i < diziUzunluğu; i++)

{
        System.Console.WriteLine("Lütfen {0}. sayısı giriniz:", i+1);
        sayiDizisi[i] = int.Parse(Console.ReadLine());

}

int toplam = 0;
foreach (var sayi in sayiDizisi)

    toplam += sayi;
    System.Console.WriteLine("Ortalama :" + toplam/diziUzunluğu);




