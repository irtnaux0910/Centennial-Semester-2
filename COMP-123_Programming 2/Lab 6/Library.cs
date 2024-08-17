using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace Lab6
{
    public class Library
    {
        private static List<Book> Books { get; set; } = new List<Book>();
        public static List<Member> Members { get; set; } = new List<Member>();
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book added successfully.");
            
        }
        public void RemoveBook(string ISBN)
        {
            foreach (Book book in Books)
            {
                if (ISBN == book.ISBN)
                {
                    Books.Remove(book);
                    Console.WriteLine("Book removed Successfully.");
                    return;
                }
            }
            Console.WriteLine("Book does not exist.");
        }
        public Book SearchBooksByTitle(string title)
        {
            foreach (Book book in Books)
            {
                if (title == book.Title)
                {
                    book.ToString();
                }
                else
                {
                    Console.WriteLine("Book cannot found in library");
                    break;
                }
            }
            return null;    
        }
        public Book SearchBooksByAuthor(string author)
        {
            foreach (Book book in Books)
            {
                if (book.Author == author)
                {
                    book.ToString();
                }
                else
                {
                    Console.WriteLine("Book cannot found in library");
                }
            }
            return null;
        }
        public Book SearchBooksByISBN(string ISBN)
        {
            foreach (Book book in Books)
            {
                if (book.ISBN == ISBN)
                {
                    return book;
                }
                else
                {
                    Console.WriteLine("Book cannot found in library");
                    break;
                }
            }
            return null;
        }
        public void DisplayAvailableBooks()
        {            
            foreach (Book book in Books)
            {
                if (book.IsAvailable)
                {
                    Console.WriteLine($"{book.Title}");                        
                }
                else
                {
                    Console.WriteLine("There is no book available at the moment.");

                }
            }           
            
        }
        public Member SearchMember(int memberId)
        {
            foreach (Member member in Members)
            {
                if (member.MemberID == memberId)
                {
                    return member;
                }
                else
                {
                    Member newMember = new Member(memberId,"blank","blank","blank");
                }
            }
            return null;
        }
        public void BorrowBook(string ISBN, int memberId)
        {
            Member member = SearchMember(memberId);
            Book borrowBook = SearchBooksByISBN(ISBN);
            if(!borrowBook.IsAvailable)
            {
                Console.WriteLine("This book is not available to borrow");
            }
            borrowBook.IsAvailable = false;
            Console.WriteLine($"{member.LastName} borrows {borrowBook.Title} successfully.");
        }
        public void ReturnBook(string ISBN)
        {
            Book returnBook = SearchBooksByISBN(ISBN);
            if (returnBook.IsAvailable)
            {
                Console.WriteLine("This book is not available to borrow");
            }
            returnBook.IsAvailable = true;
            Console.WriteLine($"{returnBook.Title} returned successfully.");
        }
        public void AddMember(Member member)
        {
            foreach (Member oldMember in Members)
            {
                if (oldMember.MemberID == member.MemberID)
                {
                    Console.WriteLine("User with this id already exist");
                    return;
                }
            }
            Members.Add(member);
            Console.WriteLine("Member added successfully");
        }
        public static void SaveLibraryToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Book book in Books)
                {
                    writer.WriteLine(book.Title);
                    writer.WriteLine(book.Author);
                    writer.WriteLine(book.ISBN);
                    writer.WriteLine(book.PublicationYear);
                    writer.WriteLine(book.Genre);
                }
            }
            Console.WriteLine("Library saved successfully");
        }
        public static void LoadLibraryFromFile(string filename) 
        {
            Console.WriteLine("Library loaded successfully.");
            using (StreamReader reader = new StreamReader(filename))
            {
                string title;
                while ((title = reader.ReadLine()) != null)
                {
                    string author = reader.ReadLine();
                    string isbn = reader.ReadLine();
                    int publicationYear = Convert.ToInt32(reader.ReadLine());
                    GenreEnum genre = (GenreEnum)Enum.Parse(typeof(GenreEnum), reader.ReadLine());
                    Books.Add(new Book(title, author, isbn, publicationYear ,genre));
                    foreach (Book loadBook in Books)
                    {
                        Console.WriteLine(loadBook);
                    }
                }
            }
        }

    }
}
