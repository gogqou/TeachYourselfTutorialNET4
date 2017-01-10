using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQXML
{
    public class Program
    {
        public static void Main(string[] args)
        {

            XElement books = XElement.Load("books.xml");
            //selecting XML

            //foreach (var o in books.Elements())
            //{
            //    Console.WriteLine((string)o.Attribute("title"));
            //}
            //Console.WriteLine(books.ToString());
            XElement book = books.Elements("book").
                FirstOrDefault(b => (string)b.Attribute("author") == "Dorman");
            book.SetElementValue("Price", 30.99M);

            //Editing XML
            book.Add(new XElement("publisher", 
                new XElement("name", "Sams Publishing"),
                new XElement("state", "IN"),
                new XElement("books", 
                from ex_book in books.Elements()
                select ex_book)));

            Console.WriteLine(books);
            
            

            //Querying XML exercise
            //XNamespace ns = "http://www.w3.org/1999/xhtml";

            //XElement document = new XElement("books",
            //    new XAttribute(XNamespace.Xmlns + "ns", ns),
            //    new XElement("book",
            //        new XElement("publisher")));
            //XElement bookElement = document.Element("book");
            //XElement publisherElement = bookElement.Element("publisher");

            //bookElement.SetElementValue("title", "Sams Teach Yourself C# 5.0 in 24 Hours");
            //bookElement.SetElementValue("isbn-10", "0-672-336523-7");
            //bookElement.SetElementValue("author", "Dorman");
            //bookElement.SetElementValue("price", 34.99M);
            //bookElement.Element("price").
            //    SetAttributeValue("currency", "US");

            //publisherElement.SetElementValue("name", "Sams Publishing");
            //publisherElement.SetElementValue("state", "IN");

            ////Console.WriteLine(document.ToString());


            //foreach (var o in document.Elements().
            //    Where(e=> (string)e.Element("author")=="Dorman"))
            //{
            //    Console.WriteLine(o.Name);
            //    Console.WriteLine(o);
            //}



            //XNamespace ns = "http://www.w3.org/1999/xhtml";

            //XElement document = new XElement(ns + "books",
            //    new XAttribute(XNamespace.Xmlns + "ns", ns),
            //    new XElement(ns + "book",
            //        new XElement(ns + "publisher")));
            //XElement bookElement = document.Element(ns + "book");
            //XElement publisherElement = bookElement.Element(ns + "publisher");

            //bookElement.SetElementValue(ns + "title", "Sams Teach Yourself C# 5.0 in 24 Hours");
            //bookElement.SetElementValue(ns + "isbn-10", "0-672-336523-7");
            //bookElement.SetElementValue(ns + "author", "Dorman");
            //bookElement.SetElementValue(ns + "price", 34.99M);
            //bookElement.Element(ns + "price").
            //    SetAttributeValue(ns + "currency", "US");

            //publisherElement.SetElementValue(ns + "name", "Sams Publishing");
            //publisherElement.SetElementValue(ns + "state", "IN");

            //Console.WriteLine(document.ToString());



            //XElement book_document = new XElement("books",
            //    new XElement("book",
            //        new XElement("title", "Sams Teach Yourself C# 5.0 in 24 hours"),
            //        new XElement("isbn-10", "0-672-336523-7"),
            //        new XElement("Author", "Dorman"),
            //        new XElement("price", new XAttribute("currency", "US"), 34.99M),
            //        new XElement("publisher",
            //            new XElement("name", "Sams Publishing"),
            //            new XElement("state", "IN"))));
            //Console.WriteLine(book_document.ToString());
            Console.ReadLine();
        }
    }
}
