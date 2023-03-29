using System;
{
    static void Main(string[] args)
    {
        new MyClass(5);
        new MyClass(3);
        new MyClass(29);
    }
}



// Constructor metot(Yapıcı metot), bir nesne üretimi sürecinde ilk tetiklenen metottur.
// Constructor new ile nesne yaratma talebi geldikten ve ilgili nesneye hafızada yer ayrıldıktan sonra tetiklenir.
// Constructor metot parametre alabilir.

// Constructor metot oluşturma:
// Sınıf adı metot adıyla aynı olmalı
// Geri dönüş değeri olmaz/belirtilmez
// Erişim belirleyicisi public olmalıdır.
// Constructor private yaparsak nesne üretimi engellenir.


class MyClass
{
    public MyClass(int a)
    {
        console.writeLine("Bir adet MyClass nesnesi oluşturulmuştur." + a);
    }
}



class MyClass
{
    public MyClass()
    {
        Console.WriteLine("1.Constructor");
    }
    public MyClass(int a) : this()   //  This constroctorlar arası atlamayı, farklı constractoru tetiklmeyei sağlar.
    {
        Console.WriteLine("2.Constructor");
    }
}







// Destructor Metot

// Yıkıcı metotlar nesne kullanımı bittikten sonra hafızanın Heap alanından silinmeden (Dispose) önce çalışan metotlardır. 
// Bu sayede nesne yok edilmeden önce yapılması gereken işlemler tamamlanır.        ~ ile tanımlanır

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Nesne Üretilmiştir");    // Constructor


        ~MyClass()
{
            Console.WriteLine("Nesne imha ediliyor...");    // Destructor   
        }

    }
}






// Deconstruct
// Public olmalı
// Geriye değer döndürmemeli (void)
// İsim olarak Deconstruct verilmeli
// Dışarıya değer taşıyacağı için out key ile tanımlanmalı.
// out olarak aldığı parametreleri Tuple olarak döndürür

class program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Furkan";
        age = 22
        };

    var(x, y) = Person;

    }
}


    class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}