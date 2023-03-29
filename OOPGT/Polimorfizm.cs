
// Polimorfizm  (Çok biçimlilik)

// Bir nesnenin birden fazla farklı türdeki referenas tarafından işaretlenebilmesidir.
// Bir nesnenin birden fazla referansla işaretlenmesi o nesnenin birden fazla türün davranışını gösterebilmesini sağlar.

// Örneğin bir kartala da kuş deriz bir papağanada. Burada kuş kelimesi birden fazla hayvana karşılık gelebilmektedir.
// Yani kartal bir yandan kartal iken bir yandan da kuştur.

// Bu hayvanların kendi türleri dışında ortak olarak 'Kuş' diye nitelendirilmesi Polimorfizmdir.

// Yani bir olguyu çoklu(poli) for(morfizmos) olarak tarif edebilmektir.

// Nesne tabanlı programlalmada Polimorfizm sadece aralarında kalıtımsal ilişki olan sınıflara uygulanabilir.


namespace polimorfizm

    class program
{
    static void Main(string[] args)
    {
        MyClass m = new MyClass();
        MyClass2 m = new MyClass();         // Normalde bu şekilde yazdığımızda hata verirdi çünkü nesne sadece kendi ismiyle üretilir.
                                            // Ancak polimorfizm sayesinde MyClass2 sınıfı bir yandan da MyClass sınıfı olacağı için MyClass2 nesnesi
                                            // MyClass referansı tarafından işaretlenebilir.
                                            // MyClass 2 MyClass'ın büyüğü olduğu için referans eder.
    }
}

class MyClass : MyClass2
{

}

class MyClass2
{

}



class program2
{
    static void Main(string[] args)
    {
        A b = new B();              // Bu yapının çalışması için B A'dan türemeli
        C c = new B();              // Hata verir çünkü B C'den türemiyor.                 
    }
}

class A
{

}

class B : A
{

}

class C
{

}



// Polimorfizm durumlarında tür dönüşümleri

// CAST  = Üst türden alt türe kalıtımsal ilişkide dönüşüm sağlar.
// Eğer kalıtımsal ilişki olmayan herhangi bir türe dönüştürülmeye çalışılırsa hata verir.


A a = new C();

C c = (C)a;     // a referansının türü A. A C'nin atası olduğu içiçn hata vermez.

D d = (D)a;     // D ile A arasında kalıtımsal bir ilişki olmadığı için hata verir.


class A
{

}

class B : A
{

}

class C : B
{

}
class D
{

}



// As Operatörü

// Cast gibi kalıtımsal ilişki olan türler arasında referans dönüşümü yapabilmemizi sağlar.

A a = new C();

C c = A as C;     // A içersindeki nesneyi C türünde verir.
