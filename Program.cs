using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Directory
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {

                case 1: //Add Number
                    NewNumber newNumber = new NewNumber();
                    newNumber.Save();

                    break;

                case 2: //Delete Number

                    DeleteNumber DeleteNumber = new DeleteNumber();
                    DeleteNumber.Delete();

                    break;

                case 3:  //Update Number
                    UpdateNumber UpdateNumber = new UpdateNumber();
                    UpdateNumber.Update();

                    break;


                case 4: // Show Directory

                    PhoneBookDatabase phoneBookDatabase = new PhoneBookDatabase();
                    PhoneBookDatabase.Show();

                    break;


                case 5:  // Search
                    Searching searching = new Searching();
                    searching.Search();

                    break;
            }
        }
    }
}
