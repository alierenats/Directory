using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory;

namespace Directory
{
    public class Searching 
    {
        public static void Search()
        {
        rollback:
            Console.WriteLine("Aramak istediginiz isimi giriniz.");
            string inputName = Console.ReadLine();


            Directory.Person matchedPerson = PhoneBookDatabase.PhoneList.FirstOrDefault(person => person.FirstName == inputName);

            if (matchedPerson != null)
            {

                Console.WriteLine(matchedPerson.FirstName + " " + matchedPerson.LastName + " " + matchedPerson.PhoneNumber);

            }

            else
            {
                Console.WriteLine("Girdiginiz isim rehberde bulunmamaktadır. Tekrar denemek ister misiniz ? (evet)(hayır)");

                string choose = Console.ReadLine();
                if (choose == "evet")
                { goto rollback; }

            }

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
