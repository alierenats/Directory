using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public class PhoneBookDatabase : IOperations
    {

        private static List<Person> _phoneList;

        static PhoneBookDatabase()
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


        public static void Show()
        {
            foreach (Person person in PhoneBookDatabase.PhoneList)
            {
                Console.WriteLine("İsim: " + person.FirstName);
                Console.WriteLine("Soyisim: " + person.LastName);
                Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                Console.WriteLine("-");

            }

        }
    }
}
