using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public class Phonebook : IPhonebook
    {
        internal static List<Person> _phoneList;



        static Phonebook()
        {
            _phoneList = new List<Person>()
            {
                new Person{FirstName="ali eren", LastName="ates", PhoneNumber="123456789" },
                new Person{FirstName="hakan", LastName="yılmaz", PhoneNumber="987654321" },
                new Person{FirstName="Cynthia E.", LastName="Jones", PhoneNumber="(415) 923-6596" },
                new Person{FirstName="Toni L.", LastName="Kenney", PhoneNumber="(450) 379-0231" },
                new Person{FirstName="Hiram S.", LastName="Morrow", PhoneNumber="(643) 928-0063" }
            };
        }


        public static List<Person> PhoneList
        {
            get { return _phoneList; }
        }

        public void Delete()
        {
        rollback:
            Console.WriteLine("Silmek istediginiz isimi giriniz.");
            string inputName = Console.ReadLine();


            Directory.Person matchedPerson = Phonebook.PhoneList.FirstOrDefault(person => person.FirstName == inputName);

            if (matchedPerson != null)
            {
                Console.WriteLine($"{inputName} kişi rehberden silinmek üzere onaylıyor musunuz ?(evet)(hayır)");
                string choose = Console.ReadLine();
                if (choose == "evet")
                {
                    Phonebook.PhoneList.Remove(matchedPerson);
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
            foreach (var person in Phonebook.PhoneList)
            {
                Console.WriteLine(person.FirstName);
            }

        }

        public void Save()
        {

            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string number = Console.ReadLine();

            Person person = new Person();
            person.FirstName = name;
            person.LastName = surname;
            person.PhoneNumber = number;

            Phonebook.PhoneList.Add(person);
            Console.WriteLine(name + " " + surname + " added successfully.");


            Console.WriteLine("Yeni Telefon Rehberi \n **********************************************");

            foreach (Person a in Phonebook.PhoneList)
            {
                Console.WriteLine("İsim: " + a.FirstName);
                Console.WriteLine("Soyisim: " + a.LastName);
                Console.WriteLine("Telefon Numarası: " + a.PhoneNumber);
                Console.WriteLine("-");

            }
        }

        public void Search()
        {
        rollback:
            Console.WriteLine("Aramak istediginiz isimi giriniz.");
            string inputName = Console.ReadLine();


            Directory.Person matchedPerson = Phonebook.PhoneList.FirstOrDefault(person => person.FirstName == inputName);

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

        public void Show()
        {
            foreach (Person person in Phonebook.PhoneList)
            {
                Console.WriteLine("İsim: " + person.FirstName);
                Console.WriteLine("Soyisim: " + person.LastName);
                Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                Console.WriteLine("-");

            }
        }

        public void Update()
        {
            Console.WriteLine("Güncellemek istediginiz isimi giriniz.");
            string inputName = Console.ReadLine();


            Directory.Person matchedPerson = Phonebook.PhoneList.FirstOrDefault(person => person.FirstName == inputName);

            if (matchedPerson != null)
            {
                Console.WriteLine("Hangi bilgiyi güncellemek istersiniz? (Ad,Soyad ,numara)");
                string updating = Console.ReadLine().ToLower();


                if (updating == "ad")
                {
                    Console.WriteLine($"Yeni {updating} değerini girin:");
                    string newValue = Console.ReadLine();
                    matchedPerson.FirstName = newValue;
                }
                else if (updating == "soyad")
                {
                    Console.WriteLine($"Yeni {updating} değerini girin:");
                    string newValue = Console.ReadLine();
                    matchedPerson.LastName = newValue;
                }
                else if (updating == "numara")
                {
                    Console.WriteLine($"Yeni {updating} değerini girin:");
                    string newValue = Console.ReadLine();
                    matchedPerson.PhoneNumber = newValue;
                }
                else
                {
                    Console.WriteLine("Bilinmeyen bir özellik seçildi.");

                }
            }
            else
            {
                Console.WriteLine($"{inputName} listemizde bulunamadı.");
            }


            Console.WriteLine("Güncel Rehber:");
            Console.WriteLine("--------------");
            foreach (var person in Phonebook.PhoneList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.PhoneNumber);
            }



        }
    }
}
