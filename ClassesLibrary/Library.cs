using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields

        //props
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        /// <summary>
        /// Collection of Libraries and their information and book lists
        /// </summary>
        /// <param name="books">Books in library's book list</Book></param>
        /// <param name="libraryName">Name of library</param>
        /// <param name="streetAddress">Library street address</param>
        /// <param name="city">Library City</param>
        /// <param name="state">Library State</param>
        /// <param name="zip">Library Zip</param>
        //ctors
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        //methods
        public override string ToString()
        {
            return LibraryName;
        }


    }
}
