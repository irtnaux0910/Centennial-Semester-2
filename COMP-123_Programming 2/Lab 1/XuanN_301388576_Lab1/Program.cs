using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*Xuan Tri Nguyen - 301388576*/

namespace XuanN_301388576_Lab1
{    
    public static class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1813, "Jane Austen", "Pride and Prejudice", 24.99, true);
            Book book2 = new Book(1967,"Gabriel García Márquez", "One Hundred Years of Solitude", 37);
            Book book3 = new Book(1615, "Miguel de Cervantes", "Don Quixote",  22.99);
            Book book4 = new Book(1925, "F. Scott Fitzgerald",  "The Great Gatsby",  20.76);
            Book book5 = new Book(1922, "James Joyce", "Ulysses",  26.99);
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine(book4);
            Console.WriteLine(book5);                            
        }
    }
}
