using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Directory
{
    class Program
    {
        private static IPhonebook _phoneBook;

        static void Main(string[] args)
        {
            _phoneBook = new Phonebook();

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
                    _phoneBook.Save();
                    break;

                case 2: //Delete Number
                    _phoneBook.Delete();
                    break;

                case 3:  //Update Number
                    _phoneBook.Update();
                    break;

                case 4: // Show Directory
                    _phoneBook.Show();
                    break;

                case 5:  // Search
                    _phoneBook.Search();
                    break;
            }
        }
    }
}
