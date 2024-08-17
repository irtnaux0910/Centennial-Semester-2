using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Book
    {
        public string  Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public GenreEnum Genre { get; set; }
        public bool IsAvailable { get; set; } 
        public Member Borrower { get; set; } 
        public DateTime DueDate { get; set; }
        public Book(string title, string author, string isbn, int publicationYear, GenreEnum genre)
        {            
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            Genre = genre;
            IsAvailable = true;
        }
        
        public override string ToString()
        {
            return  $"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nPublication Year: {PublicationYear}\nGenre: {Genre}";
        }
        public bool Overdue()
        {
            return !IsAvailable &&  DueDate < DateTime.Now;
        }

    }
}
