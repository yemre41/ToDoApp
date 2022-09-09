using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            string choice=Console.ReadLine();   
            Operations operations = new Operations();   
            switch (choice)
            {
                case "1":
                    operations.CardList();
                    break;
                case "2":
                    operations.CardAdd();
                    break;
                case "3":
                    operations.CardDelete();
                    break;
                case "4":
                    operations.CardCarry();
                    break;
            }
        }
    }
}
