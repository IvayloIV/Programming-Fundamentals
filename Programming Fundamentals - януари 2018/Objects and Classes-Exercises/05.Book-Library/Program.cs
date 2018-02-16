using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
            public Book(string title, string author, string publisher, DateTime releaseDate, string iSBN, decimal price)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                ReleaseDate = releaseDate;
                ISBN = iSBN;
                Price = price;
            }
        }
        class Libraly
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }

            public Libraly(string name)
            {
                Name = name;
                Books = new List<Book>();
            }
            public void AddBook(Book book)
            {
                Books.Add(book);
            }
        }
        static void Main(string[] args)
        {
            var book = new Libraly("Delfi");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                var insideBook = new Book(
                    tokens[0], 
                    tokens[1], 
                    tokens[2], 
                    DateTime.ParseExact(tokens[3], "dd.MM.yyyy",CultureInfo.InvariantCulture), 
                    tokens[4], 
                    decimal.Parse(tokens[5]));
                book.AddBook(insideBook);
            }
            var outputBook = new Dictionary<string, decimal>();
            foreach (var item in book.Books)
            {
                if (!outputBook.ContainsKey(item.Author))
                {
                    outputBook[item.Author] = 0;
                }
                outputBook[item.Author] += item.Price;
            }
            outputBook
                .OrderByDescending(a => a.Value)
                .ThenBy(a => a.Key)
                .ToList()
                .ForEach(a => Console.WriteLine($"{a.Key} -> {a.Value:F2}"));
        }
    }
}
