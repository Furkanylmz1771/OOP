using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Arayüz (interface), OOP'nin en önemli yapılarındandır ve temelde sınıflara sunabileceğiniz, sınıfın hangi isimde ve hangi tipte parametreleri
// alan bir metoda sahip olacağını söylemenizi sağlayan yapıdır.

namespace OOP

{


    interface IOrnek          // InterFace oluştururken class yerine interface yazılır ve verilen isimlerin başına genelde I konulur.
    {
        int x();             // İmzalarda public, private gibi erişim belirleyiciler bulunmaz.
        void y();
       int OrnekProp { get; set; }                  // interface içersinde property oluştururken erişim belirleyicisi kullanılmaz.
    }


    class Ornek : IOrnek          // Sınıflar interfacelerden kalıtım alabilir.

    {                            // Aşağıdaki yapıları kısaca oluşturmak için IOrnek üzerine gelip ampul işaretine tıklamak yeterli. 
                                //  Çıkan işarette implement interface seçtiğimiz zaman bütün değerler gelir.Ancak ortak olan değerden bir tanesi gelir.
        public int OrnekProp {      
            
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public int x()
        {
            throw new NotImplementedException();
        }

        public void y()
        {
            throw new NotImplementedException();
        }
    }

}



interface IA
{
    void x();
    void y();
    void z();
}


interface IB
{
    void x();
    void m();
    void n();
}




class Ornek : IA, IB;{



    public void m()
    {
        throw new NotImplementedException();
    }

    public void n()
    {
        throw new NotImplementedException();
    }

    public void x()             // x hem A hemde B de olduğu için ortak eleman ve hangisinden geldiğini bilmiyoruz. Bu olaya Name Hiding denir.
                                // Bu duruma düşmemek için ampulde çıkan seçeneklerden implement interface explicitly seçeneğini uygularız.
    {
        throw new NotImplementedException();
    }

    public void y()
    {
        throw new NotImplementedException();
    }

    public void z()
    {
        throw new NotImplementedException();
    }


}


// ampulde çıkan seçeneklerden implement interface explicitly seçildiğinde aşağıdaki çıktıyı verir ve Name Hiding hatasından kurtuluruz .
// Ancak bu seçenekte erişim belirleyiciler uygulanamaz ve nesne oluşturduğumuzda bu elemanlara nesne referansı üzerinden erişilemez.
// Nesne oluşturulamaz ancak referans noktası oluşturulabilir.

//  Ornek o = new Ornek();
//  IA = new Ornek();       interface referansına nokta dediğimiz zaman ( a. ) içersindei elemanlara erişebiliriz. 


//      void IA.x()
//        {
//      throw new NotImplementedException();
//      }

//       void IA.y()
//      {
//      throw new NotImplementedException();
//       }

//      void IA.z()
//       {
//    throw new NotImplementedException();
//      } 