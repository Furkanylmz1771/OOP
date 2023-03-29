using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Encapsulatıon, nesnelerimizdeki field'ların kontrollü bir şekilde dışarıya açılmasıdır.
// Nesnelerimizi başkalarının yanlış kullanımlarından korumak için kontrolsüz değişime kapatmaktır.
// c#'da encapsulatıon iki şekilde uygulanır.	Metot ile ve Property ile

namespace OOP
{

    class MyClass
    {
        int a;


        public int A
        {
            get { return a; }       // A'nın değeri okunmak istenirse get bloğu tetiklenir.
            set { a = value; }      // A'ya değer atanırsa set bloğu tetiklenir.
        }

    }


    public string Name { get; set; }

    public string Sinif { get; } = "Memeli"; // Bu property sadece okunabilir değeri değiştirilemez


}







// Ülke Sınıfı Özellikleri 

class ulke
{

    string ad;   //private kabul edilir. 
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }
    string baskent;

    public string Baskent
    {
        get { return baskent; }
        set { baskent = value; }
    }
    int nufus = 1500;

    public int Nufus
    {
        get { return nufus; }
        set { nufus = value; }
    }
    string paraBirimi;

    public string ParaBirimi
    {
        get { return paraBirimi; }
        set { paraBirimi = value; } 
    }

    public void Yazdir()
    {
        Console.WriteLine("Ülke Adı    : " + ad);
        Console.WriteLine("Başkenti    : " + baskent);
        Console.WriteLine("Nüfusu      : " + nufus);
        Console.WriteLine("Para Birimi : " + paraBirimi);
        Console.WriteLine("=============================");
    }
}