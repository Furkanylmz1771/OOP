// Abstractıon, bir sınıfın memberlarından ihtiyaç noktasında alakalı olanları gösterip, alakasız olmayanları göstermemesidir.
// Bir sınıfın uyması gereken temel yapıyı tanımlamak için abstract class yapısını kullanabilir ve gerekli modellemeyi gerçekleştirebiliriz. 
// Abstract Classlar soyut yapılanmalar olduğu için yapısal olarak iradeli bir şekilde (new operatörü vs.) nesne üretilebilir bir tür değildir.

abstract class MyClass
{

}

class MyClass2 : MyClass
{

}

// Burada new MyClass2(); komutu ile MyClass2 isimli sınıftan bir nesne üretilirse eğer burada kalıtımsal hiyerarşinin gererği olarak
// abstract class'ın da dahil normal class'ın nesneleri üretilir.



abstract class MyAbstractClass
{
    int a;


    public void x()
    {

    }

    public int MyProperty { get; set; }

    // Buraya kadar ki yazılan kodlar somut kısım.


    abstract public void Z();      // Bu abstract classs'ı implemente eden class'larda Z isminde bu imzaya karşılık bir member'in olmasını isteriz.
                                   // Z imzasına karşılık bir metodun olacağının garantisini sağladık.
                                   // public olmak zorunda
}


class MyClass : MyAbstractClass
{
    // İlgili abstract class içinde ne kadar abstract ile işaretlenmiş imza varsa hepsi buraya aktarılır.
    public override void Z()
    {
        throw new NotImplementedException();    // MyClass üzerine gelip ctrl . enter basıldığında otomatik bu alanı getirir.
    }
}