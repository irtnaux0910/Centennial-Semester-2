using System;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Search Books");
                Console.WriteLine("4. Display Available Books");
                Console.WriteLine("5. Borrow Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. Add new user");
                Console.WriteLine("8. Save Library");
                Console.WriteLine("9. Load Library");
                Console.WriteLine("10. Exit");
                Console.Write("\nEnter your choice: ");
                int choice;                
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string title;
                        string author;
                        string isbn;
                        int publicationYear;
                        GenreEnum genre;
                        Console.Write("\nEnter book title: ");
                        title = Console.ReadLine();
                        Console.Write("Enter book author: ");
                        author = Console.ReadLine();
                        Console.Write("Enter book ISBN: ");
                        isbn = Console.ReadLine();
                        Console.Write("Enter book publication year: ");
                        publicationYear = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter book genre: ");
                        genre = (GenreEnum)Enum.Parse(typeof(GenreEnum), Console.ReadLine());
                        Book book = new Book(title, author, isbn, publicationYear, genre);
                        library.AddBook(book);
                        break;
                    case 2:
                        Console.Write("Enter book ISBN: ");
                        string removeBook = Console.ReadLine();
                        library.RemoveBook(removeBook);
                        break;
                    case 3:
                        Console.WriteLine("1. Search by title");
                        Console.WriteLine("2. Search by author");
                        Console.WriteLine("3. Search by ISBN");
                        int searchChoice;
                        try
                        {
                            Console.Write("Enter type of search you want to use: ");
                            searchChoice = Convert.ToInt32(Console.ReadLine());

                            switch (searchChoice)
                            {
                                case 1:
                                    Console.Write("Enter book title: ");
                                    title = Console.ReadLine();
                                    library.SearchBooksByTitle(title);
                                    break;
                                case 2:
                                    Console.Write("Enter book author: ");
                                    author = Console.ReadLine();
                                    library.SearchBooksByAuthor(author);
                                    break;
                                case 3:
                                    Console.Write("Enter book ISBN: ");
                                    isbn = Console.ReadLine();
                                    library.SearchBooksByISBN(isbn);
                                    break;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine("List of all available books:");
                        library.DisplayAvailableBooks();
                        break;
                    case 5:
                        Console.Write("Enter the book ISBN to borrow: ");
                        isbn = Console.ReadLine();
                        Console.Write("Enter your member id: ");
                        int memberId = Convert.ToInt32(Console.ReadLine());                        
                        Book borrowBook = library.SearchBooksByISBN(isbn);
                        Member member = library.SearchMember(memberId);                        
                        library.BorrowBook(isbn, memberId);                        
                        break;
                    case 6:
                        Console.Write("Enter the book ISBN: ");
                        isbn = Console.ReadLine();
                        try
                        {
                            library.ReturnBook(isbn);
                        }
                        catch
                        {
                            Console.WriteLine($"{isbn} maybe returned before or this book is not our property");
                        }
                        break;
                    case 7:
                        Console.Write("Enter user id: ");
                        memberId= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the first name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter the last name: ");
                        string lastName = Console.ReadLine(); ;
                        Console.Write("Enter the your email: ");
                        string email = Console.ReadLine();
                        Member newMember = new Member(memberId, firstName, lastName, email);
                        library.AddMember(newMember);
                        break;
                    case 8:
                        Library.SaveLibraryToFile("XuanTriNguyen_SaveLibrary.json");
                        break;
                    case 9:
                        Library.LoadLibraryFromFile("XuanTriNguyen_Library.txt");                        
                        break;                    
                    case 10:
                        Console.WriteLine("Thank you for using our Library Managing System");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid number. Please enter a number from 1 to 9");
                        break;
                }
                Console.WriteLine("\n\n");
            }            
            Console.ReadKey();
        }        
    }
}
