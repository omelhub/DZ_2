using Library;

Book book0 = new() { Title = "1984", Author = "Дж. Оруэлл", Year = 1948 };
Book book1 = new() { Title = "451 градус по Фаренгейту", Author = "Рэй Брэдбери", Year = 1953 };
Book book2 = new() { Title = "Мы", Author = "Замятин", Year = 1920 };

Library.Library library = new();
library.addBook(book0);
library.addBook(book1);
library.addBook(book2);

List<Book> books = (List<Book>)library.getAllBooks();
foreach (Book book in books)
{
    Console.WriteLine(book.Title + " " + book.Author + " " + book.Year + " " + book.Id);
}

Console.ReadKey();