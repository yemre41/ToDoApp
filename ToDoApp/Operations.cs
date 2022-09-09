using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Operations
    {
        public List<CardContentcs> Cards = new List<CardContentcs >();

        public void CardsContext()
        {
            Cards.Add(new CardContentcs() { Header = "Futbol", Content = "Gösterilen Kartlar", Person = "Ali",Size="2",BoardType="ToDo"}) ;
            Cards.Add(new CardContentcs() { Header = "Basketbol", Content = "3lük İsabeti", Person = "Mehmet",Size="3",BoardType="InProgress"});
            Cards.Add(new CardContentcs() { Header = "Voleybol", Content = "Smaç Hızı", Person = "Okan",Size="4",BoardType="Done" });
        }
        public void CardList()
        {
            CardsContext();

            Console.WriteLine("ToDo Line");
            Console.WriteLine("**********");
            foreach (var item in Cards)
            {
                if (item.BoardType=="ToDo")
                {
                    Console.WriteLine("Başlık       :" + item.Header);
                    Console.WriteLine("İçerik       :" + item.Content);
                    Console.WriteLine("Atanan Kişi  :" + item.Person);
                    Console.WriteLine("Büyüklük     :" + item.Size);
                    Console.WriteLine("-");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("InProgrss Line");
            Console.WriteLine("**********");
            foreach (var item in Cards)
            {
                if (item.BoardType == "InProgress")
                {
                    Console.WriteLine("Başlık       :" + item.Header);
                    Console.WriteLine("İçerik       :" + item.Content);
                    Console.WriteLine("Atanan Kişi  :" + item.Person);
                    Console.WriteLine("Büyüklük     :" + item.Size);
                    Console.WriteLine("-");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Done Line");
            Console.WriteLine("**********");
            foreach (var item in Cards)
            {
                if (item.BoardType == "Done")
                {
                    Console.WriteLine("Başlık       :" + item.Header);
                    Console.WriteLine("İçerik       :" + item.Content);
                    Console.WriteLine("Atanan Kişi  :" + item.Person);
                    Console.WriteLine("Büyüklük     :" + item.Size);
                    Console.WriteLine("-");
                    Console.ReadKey();
                }
            }


        }
        public void CardAdd()
        {
            Console.WriteLine("Başlık giriniz...");
            string header = Console.ReadLine();
            Console.WriteLine("İçerik giriniz...");
            string content=   Console.ReadLine();
            Console.WriteLine("Büyüklük giriniz..->XS(1),S(2),M(3),L(4),XL(5)");
            string Size =   Console.ReadLine();
            if (Convert.ToInt32( Size) == (int)size.XS)
            {
                Size ="XS" ;
                
            }
            if (Convert.ToInt32(Size) == (int)size.S)
            {
                Size = "S";
            }
            if (Convert.ToInt32(Size) == (int)size.M)
            {
                Size = "M";
            }
            if (Convert.ToInt32(Size) == (int)size.L)
            {
                Size = "L";
            }
            if (Convert.ToInt32(Size) == (int)size.XL)
            {
                Size = "XL";
            }
            Console.WriteLine("BoardType girinizz..(TODO:1, IN PROGRESS:2, DONE:3) ");
            string boardtype = Console.ReadLine();
            if (boardtype=="Todo")
            {
                boardtype = "ToDo";
            }
            else if (boardtype=="InProgress")
            {
                boardtype = "InProgress";
            }
            else if (boardtype=="Done")
            {
                boardtype = "Done";
            }


            Console.WriteLine("Kişi seçiniz");
            string person =  Console.ReadLine();

            Cards.Add(new CardContentcs() { Header=header,Content=content,Size=Size,Person=person,BoardType=boardtype});
            Console.WriteLine("Başlığı "+header+" olan"+" İcerigi "+content+" olan"+" Buyuklugu "+Size+" olan"+" Kisisi "+person+"  Boardtype ı"+boardtype+"  kişi eklenmıstır");
            Console.ReadKey();            
        }
        public void CardDelete()
        {
            CardsContext();
            Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz...");
            string header = Console.ReadLine();
            foreach (var item in Cards)
            {
                if (item.Header==header)
                {
                    Console.WriteLine(item.Header + " Başlığı silinecenek silmek istiyorsanız(Y/N) seçiniz..");
                    char choice =Convert.ToChar( Console.ReadLine());
                    if (choice=='Y')
                    {
                        Cards.Remove(item);
                        Console.WriteLine(item.Header + " Başlıgı basariyla silindi..");
                    }
                    else 
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aradıgınız kriterde baslik bulunamadı");
                    Console.WriteLine("Yeniden denemek için (1)");
                    Console.WriteLine("Çıkış yapmak için(2)");
                    string secim = Console.ReadLine();
                    if (secim=="1")
                    {
                        CardDelete();
                    }
                    else if (secim=="2")                  
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz karakter girdiniz..");
                        Console.ReadKey();
                    }
                }

            }
            
        }
        public void CardCarry()
        {
            CardsContext();
            Console.WriteLine("Lütfen tasimak istediginiz kartin basligini giriniz..");
            string header = Console.ReadLine();
            foreach (var item in Cards)
            {
                if (item.Header==header)
                {
                    Console.WriteLine("Bulunan kart bilgiler..");
                    Console.WriteLine("*******************************************");

                    Console.WriteLine("Başlık      :  {0}", item.Header);
                    Console.WriteLine("İçerik      :  {0}", item.Content);
                    Console.WriteLine("Atanan Kişi :  {0}", item.Person);
                    Console.WriteLine("Büyüklük    :  {0}", item.Size);
                    Console.WriteLine("Line        :  {0}\n", item.BoardType);

                    Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");

                   string secim= Console.ReadLine();
                    if (secim=="1")
                    {
                        item.BoardType = "Todo";
                        Console.WriteLine("İşlem tamamlandı..");
                        Console.WriteLine(item.Header + " " + item.Content + " " + item.Size + " " + item.Person + " " + item.BoardType);
                        Console.ReadKey();
                    }
                    else if (secim=="2")
                    {
                        item.BoardType = "InProgress";
                        Console.WriteLine("İşlem tamamlandı..");
                        Console.WriteLine(item.Header + " " + item.Content + " " + item.Size + " " + item.Person + " " + item.BoardType);
                        Console.ReadKey();
                    }
                    else if (secim=="3")
                    {
                        item.BoardType = "Done";
                        Console.WriteLine("İşlem tamamlandı..");
                        Console.WriteLine(item.Header + " " + item.Content + " " + item.Size + " " + item.Person + " " + item.BoardType);
                        Console.ReadKey();
                    }

                    
                }
                else
                {
                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı.");
                }
            }

        }
        public enum size
        {
            XS=1,
            S,
            M,
            L,
            XL
        }


    }
}
