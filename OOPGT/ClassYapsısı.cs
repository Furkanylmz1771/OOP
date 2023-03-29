
public class Class1
{
    public Class1()
    {

    }
}

class ornekModel
{
    int a = 1;
}



// OOP'de bir object oluşturmak için öncelikle o objenin modellenmesi gerekir.	
// Bir objenin(nesnenin) modelini oluşturmak içinse class yapısı kullanılır.

// Classlar bir referans türüdür.	

// Bir class tanımlamasında tanımlanan yerde (namespace içinde/dışında) aynı isimde birden fazla class tanımlanamaz.

// Bir class tanımlandığında o class adı bir türdür.Haliyle o türü kullanabilmek için direkt olarak class adını kullanırız.

// ornekModel w;	Buradaki ornekModel int,string tarzında bir değişken yerine geçer ve referans türlü bir değişkendir.

// This Keyworü : Sınıfın o anki nesnesini temsil eder. Ayrıca constroctorlar arası atlamayı, farklı constractoru tetiklmeyei sağlar.



// FİELD

// Field = Nesne içersinde veri depoladığımız/tuttuğumuz alanlardır. Nesne üzerinde değer tutmamızı sağlayan yapılardır.
// Fieldlerde default değerler otomatik atanır.		int a;		0 değeri alır çünkü int default değeri 0'dır

class MyClass
{
    int a;			// Bu a değişkeni class içersinde tanımlandığı için bir fielddir.
}



//PROPERTY

// Nesne içersinde özellik/property sağlar.
// Davranışsal olarak nesne üzerinde bir değer okuma ve değer atama işlemlerinde kullanılır.
// Esasında bir metottur. Ancak fiziksel olarak metottan farkı parametre almaz, içersinde get ve set olan iki adet blok alır.
// Propererty ve Metot arasındaki en büyük fark propertlerin kesinlikle bir türü olmalı void olamaz metotlar olabilir.

public int x
{
    get
    {
        return 0;
    }
    set
    {
        // Atanan veri buradan yakalanır.
    }
};

//Property çağrıldığında get bloğu tetiklenir, değer gönderiyorsak set bloğu tetiklenir. 

// Property yapıları özünde nesne içersindeki bir fieldin dışarıya kontrollü açılmasını ve,
// kontrollü bir şekilde dışarıdan değer almasını sağlayan yapılardır.	Propertylerin bu işlemine ENCAPSULATİON denir.

class MyClass
{
    int yasi;
    string b;

    // property hangi türden bir fieldi temsil ediyorsa o türden olamlıdır.
    // propertyler temsil ettikleri fieldlerin isimlerinin başharfi büyük olacak şekilde isimlendirilir.	(Yasi)

    public int Yasi
    {
        get
        {
            // propertyler üzerinden değer talep edildiğinde bu blok tetiklenir.
            // Yani değer buradan gönderilir.
            return yasi;
        }
        set
        {
            yasi = value;
        }



        // Nesne Oluşturma

        Type x = new Type();

    class Program
    {
        static void Main(string[] args)
        {
            new MyClass();  // Referanssız nesne oluşturuldu	// Nesne oluşturmak için new anahtar sözcüğü kullanılır.
        }
    }



    // Nesne Kopyalama Davranışları	(Shallow Copy	-	Deep Copy)

    // Shallow Copy
    //	Var olan bir nesnenin, değerin referansının kopyalanmasıdır. Eldeki değer çoğaltılamaz. Birden fazla referansla işaretlenmiş olur.

    MyClass m1 = new MyClass();
    MyClass m2 = new MyClass();
    MyClass m3 = m1;

    m1 = m2;
	m2 = m1;
	m1 = m1;

    // Deep Copy
    // Var olan bir nesne, deep copy ile kopyalanıyprsa eğer ilgili nesne miktarı çoğalır.
    // Aynı özelliklere ve değerlere sahip olan bellekte farklı bir nesne oluşur.


