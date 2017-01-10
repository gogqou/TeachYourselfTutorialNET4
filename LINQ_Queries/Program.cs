using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Contact> contacts = Contact.GetList();
            var query1 =
                from contact in contacts
                select new
                {
                    Name = contact.LastName + ", " + contact.FirstName
                };
            foreach(var contact in query1)
            {
                Console.WriteLine(contact.Name);
            }
            var query2 =
                from contact in contacts
                where contact.LastName.StartsWith("M")
                orderby contact.LastName descending
                select contact.LastName;
            foreach(var contact in query2)
            {
                Console.WriteLine(contact);
            }
            var query3 =
                from contact in contacts
                group contact by contact.LastName[0] into nameGroup
                where nameGroup.Count() > 2
                orderby nameGroup.Key
                select nameGroup;
            foreach(var nameGroup in query3)
            {
                Console.WriteLine("Last names starting with {0}", nameGroup.Key);
                foreach(var name in nameGroup)
                {
                    Console.WriteLine(name.LastName);
                }
            }

            Console.ReadLine();

        }

    }
}
