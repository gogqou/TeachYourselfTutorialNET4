using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressions
{
    public class Contact
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StateProvince { get; set; }

        public static IEnumerable<Contact> GetList()
        {
            int id = 1;
            yield return new Contact { Id = id++, FirstName = "Jim", LastName = "Morrison", DateOfBirth = new DateTime(1943, 12, 8) };
            yield return new Contact { Id = id++, FirstName = "Ray", LastName = "Manzarek", DateOfBirth = new DateTime(1939, 2, 12) };
            yield return new Contact { Id = id++, FirstName = "Robby", LastName = "Krieger", DateOfBirth = new DateTime(1946, 1, 8) };
            yield return new Contact { Id = id++, FirstName = "John", LastName = "Densmore", DateOfBirth = new DateTime(1944, 12, 1) };
            yield return new Contact { Id = id++, FirstName = "Freddie", LastName = "Mercury", DateOfBirth = new DateTime(1946, 9, 5) };
            yield return new Contact { Id = id++, FirstName = "Brian", LastName = "May", DateOfBirth = new DateTime(1947, 7, 19) };
            yield return new Contact { Id = id++, FirstName = "John", LastName = "Deacon", DateOfBirth = new DateTime(1951, 8, 19) };
            yield return new Contact { Id = id++, FirstName = "Roger", LastName = "Taylor", DateOfBirth = new DateTime(1949, 7, 26) };
            yield return new Contact { Id = id++, FirstName = "Johnny", LastName = "Van Zant", DateOfBirth = new DateTime(1959, 2, 27) };
            yield return new Contact { Id = id++, FirstName = "Gary", LastName = "Rossington", DateOfBirth = new DateTime(1951, 12, 4) };
            yield return new Contact { Id = id++, FirstName = "Rickey", LastName = "Medlocke", DateOfBirth = new DateTime(1950, 1, 17) };
            yield return new Contact { Id = id++, FirstName = "Michael", LastName = "Cartellone", DateOfBirth = new DateTime(1962, 7, 7) };
            yield return new Contact { Id = id++, FirstName = "Mark", LastName = "Matejka", StateProvince = "FL" };
            yield return new Contact { Id = id++, FirstName = "Robert", LastName = "Kearns" };
            yield return new Contact { Id = id++, FirstName = "Peter", LastName = "Keys", DateOfBirth = new DateTime(1965, 5, 30) };
            yield return new Contact { Id = id++, FirstName = "Jimmy", LastName = "Page", DateOfBirth = new DateTime(1944, 1, 9) };
            yield return new Contact { Id = id++, FirstName = "Robert", LastName = "Plant", DateOfBirth = new DateTime(1948, 8, 20) };
            yield return new Contact { Id = id++, FirstName = "John", LastName = "Paul Jones", DateOfBirth = new DateTime(1946, 1, 3) };
            yield return new Contact { Id = id++, FirstName = "John", LastName = "Bonham", DateOfBirth = new DateTime(1948, 5, 31) };
            yield return new Contact { Id = id++, FirstName = "David", LastName = "Coverdale", DateOfBirth = new DateTime(1951, 9, 22) };
            yield return new Contact { Id = id++, FirstName = "Eric", LastName = "Clapton", DateOfBirth = new DateTime(1945, 3, 30) };
            yield return new Contact { Id = id++, FirstName = "Jeff", LastName = "Beck", DateOfBirth = new DateTime(1944, 7, 24) };
            yield return new Contact { Id = id++, FirstName = "David", LastName = "Bowie", DateOfBirth = new DateTime(1947, 1, 8) };
        }

    }
}
