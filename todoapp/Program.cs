using System;
using System.Collections.Generic;

namespace todoapp
{
    class Program
    {
        static void Main(string[] args)
        {
          
         List<List<string>> todo=new List<List<string>>();
         List<List<string>> ınprogress=new List<List<string>>();
         List<List<string>> done=new List<List<string>>();
    
         


         AnaEkran();
         
         
         

         void AnaEkran() {
         

         Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :\n"+"*******************************************");
         Console.WriteLine("(1) Board Listelemek");
         Console.WriteLine("(2) Board'a Kart Eklemek");
         Console.WriteLine("(3) Board'dan Kart Silmek");
         Console.WriteLine("(4) Kart Taşımak");
         

         try {
             int seçim=int.Parse(Console.ReadLine());
         if(seçim==1) {
         Board(); }
         if(seçim==2) {
         KartEkle(); }
         if(seçim==3) {
         KartSil(); }
         if(seçim==4) {
         KartTaşı(); }
         if(seçim<1 || seçim >4) {
         Console.WriteLine("Lütfen 1 ile 4 arasında bir rakam giriniz");
         AnaEkran();
         } }
         catch {
         Console.WriteLine("Lütfen 1 ile 4 arasında bir rakam giriniz");
         AnaEkran();
         }
         


         } 
         

         




         void Board() {


         Console.WriteLine("TODO Line\n"+"************************");
         foreach (var item in todo)
         { 
             foreach (var eleman in item)
             {
                 Console.WriteLine(eleman);       
             }
             Console.WriteLine("\n");
         }
        

         Console.WriteLine("IN PROGRESS Line\n"+"************************"); 
         foreach (var item in ınprogress)
         { 
             foreach (var eleman in item)
             {
                 Console.WriteLine(eleman);   
             }
             Console.WriteLine("\n");
         }
         
         Console.WriteLine("DONE Line\n"+"************************");
         foreach (var item in done)
         { 
             foreach (var eleman in item)
             {
                 Console.WriteLine(eleman);     
             }
             Console.WriteLine("\n");
         }

         Console.WriteLine("Anaekrana dönmek için 1'i tuşlayınız");
         
         if(int.Parse(Console.ReadLine())==1)
         AnaEkran(); 
         else 
         Console.WriteLine("Anaekrana dönmek için 1'i tuşlayınız");
         

         }





          void KartEkle() {
        
          List<string> kart=new List<string>(); 

          Console.WriteLine("Başlık Giriniz                                  :");
          string başlık=Console.ReadLine();
          kart.Add("Başlık      :"+başlık);


          Console.WriteLine("İçerik Giriniz                                  :");
          string içerik=Console.ReadLine();
          kart.Add("İçerik      :"+içerik);


          Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
          int büyüklük=int.Parse(Console.ReadLine());
          if(büyüklük<1 || büyüklük>5)
          Console.WriteLine("Lütfen 1 ile 5 arasında bir seçim yapınız");
          if(büyüklük==1)
          kart.Add("Büyüklük    :"+büyüklükler.XS);
          if(büyüklük==2)
          kart.Add("Büyüklük    :"+büyüklükler.S);
          if(büyüklük==3)
          kart.Add("Büyüklük    :"+büyüklükler.M);
          if(büyüklük==4)
          kart.Add("Büyüklük    :"+büyüklükler.L);
          if(büyüklük==5)
          kart.Add("Büyüklük    :"+büyüklükler.XL);
          

          Console.WriteLine("Kişi Seçiniz                                    :\n"+"1=Ali Yılmaz\n"+"2=İbrahim Çelik\n"+"3=İlker Ertürk\n"+"4=Hazar Küpeli\n");
          int seçim=int.Parse(Console.ReadLine());
          try {
          if(seçim<1 || seçim>4) {
          Console.WriteLine("Hatalı Girişler yaptınız"); }
          else if (seçim==1) {
          kart.Add("Atanan Kişi :"+"Ali Yılmaz"); }
          else if (seçim==2) {
          kart.Add("Atanan Kişi :"+"İbrahim Çelik"); }
          else if (seçim==3) {
          kart.Add("Atanan Kişi :"+"İlker Ertürk"); }
          else if (seçim==4) {
          kart.Add("Atanan Kişi :"+"Hazar Küpeli"); }
          else {
          Console.WriteLine("Hatalı girişler yaptınız!,Lütfen 1 ile 4 arasında bir seçim yapınız");
          KartEkle();
          }
          }
          catch {
          Console.WriteLine("Hatalı girişler yaptınız!,Lütfen 1 ile 4 arasında bir seçim yapınız!");
          KartEkle();
          }


          Console.WriteLine("Lütfen Line Seçiniz");
          int a=int.Parse(Console.ReadLine());
          if(a==1)
          todo.Add(kart);
          if(a==2)
          ınprogress.Add(kart);
          if(a==3)
          done.Add(kart);
          
        
          Console.WriteLine("İşlem Tamamlandı ana ekrana dönülüyor....\n");
          AnaEkran();

          
          }








         void KartSil() {
          
         Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n"+"Lütfen kart başlığını yazınız");
         string silinen="Başlık      :"+Console.ReadLine();
         int kontrol=0;
         
         foreach (var item in todo)
         {
              foreach(var eleman in item)
             {
                 if(silinen==eleman) {
                     kontrol++;
                 item.Clear();
                 Console.WriteLine("İtem silindi ana ekrana dönmek için 1'i tuşlayınız");
                 AnaEkran();  }
             }
         }
         

         foreach (var item in ınprogress)
         {
              foreach(var eleman in item)
             {
                 if(silinen==eleman) {
                     kontrol++;
                 item.Clear();
                 Console.WriteLine("İtem silindi ana ekrana dönmek için 1'i tuşlayınız");
                 AnaEkran();  }
             }
         }


         foreach (var item in done)
         {
              foreach(var eleman in item)
             {
                 if(silinen==eleman) {
                     kontrol++;
                 item.Clear();
                 Console.WriteLine("İtem silindi ana ekrana dönmek için 1'i tuşlayınız");
                 AnaEkran();  }
             }
         }
          
         if(kontrol==0) {
             Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n"+"* Silmeyi sonlandırmak için : (1)\n"+"* Yeniden denemek için : (2)\n");
             int cevap=int.Parse(Console.ReadLine());
             if(cevap==1)
             AnaEkran();
             if(cevap==2)
             KartSil(); 
         }
           
         else{
             AnaEkran();
         }


         }
         







         void KartTaşı() {

         List<string> ekleme=new List<string>();    
         Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\n"+"Lütfen kart başlığını yazınız:");
         string başlık="Başlık      :"+Console.ReadLine();
         Console.WriteLine("Bulunan Kart Bilgileri:\n"+"**************************************");
         int kontrol=0;
         
         foreach (var item in todo)
         {
             foreach (var eleman in item)
             {    
                 if(başlık==eleman) {
                     foreach(var a in item) {
                  Console.WriteLine(a);
                  ekleme.Add(a);
                  kontrol++;
                  }
                  Console.WriteLine("Line        :TO DO");
                  item.Clear();
                  break;
                  }       
             }


         }
         
         foreach (var item in ınprogress)
         {
            foreach (var eleman in item)
            {
                if(başlık==eleman) {
                     foreach(var a in item) {
                  Console.WriteLine(a);
                  ekleme.Add(a);
                  kontrol++;
                  }
                  Console.WriteLine("Line        :IN PROGRESS");
                  item.Clear();
                  break;
                  }       
             }


         }

         foreach (var item in done)
         {
            foreach (var eleman in item)
            {
                 if(başlık==eleman) {
                     foreach(var a in item) {
                  Console.WriteLine(a);
                  ekleme.Add(a);
                  kontrol++;
                  }
                  Console.WriteLine("Line        :DONE");
                  item.Clear();
                  break;
                  }
             }
             
         }
           
          if(kontrol>0) { 

          Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n"+"(1)TODO "+"(2)IN PROGRESS "+"(3)DONE ");
          string istenen=Console.ReadLine();
          if(istenen=="1")
          todo.Add(ekleme);
          if(istenen=="2")
          ınprogress.Add(ekleme);
          if(istenen=="3")
          done.Add(ekleme);  

          AnaEkran();
          }

          else {

              Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n"+"* İşlemi sonlandırmak için : (1)\n"+"* Yeniden denemek için : (2)\n");
              int kcevap=int.Parse(Console.ReadLine());
              if(kcevap==1)
              AnaEkran();
              if(kcevap==2)
              KartTaşı();

          }

          } 




        }
        
    } 



    enum büyüklükler
    {
     
    XS=1,
    S,
    M,
    L,
    XL 

    }
    
} 
//The End.