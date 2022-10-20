using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : ILibrary
    {
        private static Library? instance;

        public Library(){}

        public static Library getInstance()
        {
            if (instance == null)
                instance = new Library();
            return instance;
        }

        List<Book> Books { set; get; } = new();

        public void addBook(Book book) //bool?????????
        {
            Books.Add(book);
        }

        public IEnumerable<Book> getAllBooks()
        {
            return Books;
        }

        public Book getBook(int Id)
        {
            return Books.Find(x => x.Id == Id);
        }

        public IEnumerable<Book> getBooksOfAuthor(string Author)
        {
            return Books.FindAll(x => x.Author == Author);
        }
    }
}
