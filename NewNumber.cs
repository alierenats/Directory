using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory;

public class NewNumber : IOperations
{

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

        PhoneBookDatabase.PhoneList.Add(person);
        Console.WriteLine(name + " " + surname + " added successfully.");


        Console.WriteLine("Yeni Telefon Rehberi \n **********************************************");

        foreach (Person a in PhoneBookDatabase.PhoneList)
        {
            Console.WriteLine("İsim: " + a.FirstName);
            Console.WriteLine("Soyisim: " + a.LastName);
            Console.WriteLine("Telefon Numarası: " + a.PhoneNumber);
            Console.WriteLine("-");

        }

    }
}