
// This - Base  - readonly 

// This Keywordü
// Bir sınıfın uygulamanın herhangi bir noktasında üretilmiş olan nesnelereini sınıf içersinde temsil etmemizi sağlar.
// Bir sınıf içersinde bulunan birden çok constructor overloadı'ı arasında atlamayı sağlar.


// Base Keywordü
// Bir instance'ın base class'ını sınıf modeli içersinde temsil eden bir keyword'dur. Bir sınıf herhangi bir sınıftan kalıtım almıyor ise
// base keywordü object türünden bir instance'ye karşılık gelir.
// Base keyword'ü base class'daki constructor'lardan seçim yapmamızı sağlar.



// Readonly Keyword'ü
// Bir class içersinde tanımlanmış olan değişkenin veya referansın sadce okunabilir olmasını sağlayan bir keywor'dür.
// readonly keywordü ile işaretlenmiş olan referansların değerleri tanımlanma noktasında ya da constructor'da verilebilir.
// const yapılanma ile readonly rasındaki fark readonly'de constructor içinde değer atamsı yapılabilir ama const ile bu yapılamaz<

new MyClass2();

// this kısmı

class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int a) : this()
    {
        Console.WriteLine("a parametreli constructor");
    }

    public MyClass(int a, string b) : this(a)
    {
        Console.WriteLine("a ve b parametreli constructor");
    }
}

// base kısmı

class MyClass2 : MyClass
{
    public MyClass2() : base(3, "")
    {

        Console.WriteLine("Son constructor");
    }
}

// readonly kısmı

class MyClass3
{
    readonly object x = 5;      // değer tanımlanırken verildi
    const string y;    // İlk değer atanması yapıldı
    public MyClass3()
    {
        x = 15;             // constructor içinde verildi
        y = 20;             // const olduğu için y değeri constructor içersinde atanamaz.
    }
}