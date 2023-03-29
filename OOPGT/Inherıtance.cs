
// Kalıtım OOP'nin en önemli özelliğidir.

// Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilir.

// Aynı aile grubundan gelen nesnelerin benzer özelliklerini tekrar tekrar herbirine tanımlamak yerine bir üst sınıfa tanımlanması
// ve her bir sınıfın bu özellikleri üst sınıftan kalıtımsal olarak almasını sağlar.

// Örneğin bir kadın ve bir erkeğin kesin olarak isimleri vardır. İkisinede gelip isim yazmaktansa
// insan adından bir class yaratıp içine isim diye bir property koyarız ve kadın ve erkek ismi kalıtımsal olarak almış olur.

// İki sınıf arasındaki ortak özellikleri tek tek yazmaktansa bir sınıf oluşturup orada tanımlamaya denir...


// C# da iki sınıf arasında kalıtımsal ilişlki kurabilmek için ":" operatörü kullanılır.


//Şirkette çalışanların bilgisi isteniyor. Tek tek ad soyad medeni hal girmek yerine genel olarak personel sınıfı oluşturup bilgiler burada verilir.

{
    static void Main(string[] args)
    {
        Muhasebeci muhasebeci = new Muhasebeci();
    }
}


class personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}

class Muhasebeci : personel
{
    public bool Musavir { get; set; }       // Ayrı olarak değer verilebilir.

}

class yazilimci : personel
{

}

class Mudur : personel
{

}







class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int KM { get; set; }
    private int Fiyat { get; set; }         // Bu özellik private olduğu için aktarılmaz.
}


class Opel : Araba        // Soldaki(Opel) sağdakinden(Araba) kalıtım alır.
{

}








class A
{
    Console.WriteLine("A nesnesi oluşturuldu");
  
}

class B : A
{
    Console.WriteLine("B nesnesi oluşturuldu");
}

class C : B
{
    Console.WriteLine("C nesnesi oluşturuldu");
}

class D : C
{
    Console.WriteLine("D nesnesi oluşturuldu");
}

new D();    // new D() dediğimizde her bir sınıfın base classına gider en başa doğru ve nesne üretimi oradan başlar.
// Yani consola yazdırdığımızda sıralama "A nesnesi oluşturuldu" ile başlar ve "D nesnesi oluşturuldu" ile biter.






// Base Class (parent) ve Derived Class (child)

// Kalıtım veren sınıfa Base Class kalıtım alan sınıfa ise Derived Class denir
// class Opel : Araba    Opel = Derived Class   Araba = Base Class
// Bir sınıfın sadece tek bir Base Classı olabilir. Ancak bir classın birden çok Derived classı olabilir.




// Nesnelerin Atası Object Türü

// C# programlama dilinde tüm sınıflar Ogject sınıfından türetilir. 

// Kalıtımsal bir durum olmadığı halde içinde tanımlanmayan fonksiyonlar (Equals - GetType - ToString) nereden gelir = Object sınıfından


class Insan         // Tanımlanan sınıf bu şekilde herhangi bir kalıtım almıyorsa default olarak Object sınıfından türer.
{

}