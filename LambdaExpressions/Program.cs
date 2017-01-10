using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Contact> contacts = Contact.GetList();
            var query1 = contacts.
                Where(contact => contact.LastName.StartsWith("M")).
                OrderBy(contact => contact.LastName[1]).
                Select(contact => contact.LastName);
            foreach(var contact in query1)
            {
                Console.WriteLine(contact);
            }
            var query2 = contacts.
                GroupBy(contact => contact.LastName[0]).
                OrderBy(IGrouping => IGrouping.Key).
                Where(group => group.Count() > 2);
            foreach(var group in query2)
            {
                Console.WriteLine("Names starting with {0}", group.Key);
                
                foreach (Contact contact in group)
                {
                    Console.WriteLine(contact.LastName);
                }
               
            }

            Console.ReadLine();
        }

    }
}
