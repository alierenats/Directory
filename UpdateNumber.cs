using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Directory;

namespace Directory
{
    public class UpdateNumber : IOperations
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Güncellemek istediginiz isimi giriniz.");
            string inputName = Console.ReadLine();


            Directory.Person matchedPerson = PhoneBookDatabase.PhoneList.FirstOrDefault(person => person.FirstName == inputName);

            if (matchedPerson != null)
            {
                Console.WriteLine("Hangi bilgiyi güncellemek istersiniz? (Ad,Soyad ,numara)");
                string updating = Console.ReadLine().ToLower();

                Console.WriteLine($"Yeni {updating} değerini girin:");
                string newValue = Console.ReadLine();

                switch (updating)
                {
                    case "ad":
                        matchedPerson.FirstName = newValue;
                        break;
                    case "soyad":
                        matchedPerson.LastName = newValue;
                        break;
                    case "numara":
                        matchedPerson.PhoneNumber = newValue;
                        break;

                    default:
                        Console.WriteLine("Bilinmeyen bir özellik seçildi.");
                        break;
                }

                Console.WriteLine($"{inputName} bilgisi güncellendi.");
            }
            else
            {
                Console.WriteLine($"{inputName} listemizde bulunamadı.");
            }

      
            Console.WriteLine("Güncel Rehber:");
            Console.WriteLine("--------------");
            foreach (var person in PhoneBookDatabase.PhoneList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.PhoneNumber);
            }



        }

    }
}
