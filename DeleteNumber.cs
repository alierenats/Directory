using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory;
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace Directory
{
    public class DeleteNumber : IOperations
    {


        public void Delete()
        {
        rollback:
            Console.WriteLine("Silmek istediginiz isimi giriniz.");
            string inputName = Console.ReadLine();


            Directory.Person matchedPerson = PhoneBookDatabase.PhoneList.FirstOrDefault(person => person.FirstName == inputName);

            if (matchedPerson != null)
            {
                Console.WriteLine($"{inputName} kişi rehberden silinmek üzere onaylıyor musunuz ?(evet)(hayır)");
                string choose = Console.ReadLine();
                if (choose == "evet")
                {
                    PhoneBookDatabase.PhoneList.Remove(matchedPerson);
                    Console.WriteLine($"{inputName} listemizden silindi.");
                }

            }
            else
            {
                Console.WriteLine($"{inputName} listemizde bulunamadı.");
                Console.WriteLine("Tekrar denemek ister misin? (evet)(hayır)");
                string choose = Console.ReadLine();
                if (choose == "evet")
                { goto rollback; }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Islem isteginiz üzere gerceklestirilmedi.");
            Console.WriteLine("--------------------------");



            Console.WriteLine("Güncel Rehber:");
            foreach (var person in PhoneBookDatabase.PhoneList)
            {
                Console.WriteLine(person.FirstName);
            }

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
            throw new NotImplementedException();
        }
    }

}

