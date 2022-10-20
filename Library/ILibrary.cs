using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

internal interface ILibrary
{
    void addBook(Book book);                             //bool?????????
    Book getBook(int Id);
    IEnumerable<Book> getAllBooks();
    IEnumerable<Book> getBooksOfAuthor(string Author);
}
