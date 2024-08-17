using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanN_301388576_Lab1
{
    class Book
    {
        private int publicationYear;
    private string author;
    private string title;
    private bool isHardCover;
    private double price;
    public Book(int publicationYear, string author, string title, double price, bool isHardCover = false)
    {
        this.publicationYear = publicationYear;
        this.author = author;
        this.title = title;
        this.isHardCover = isHardCover;
        this.price = price;
    }
    public override string ToString()
    {
        string coverType;
        if (isHardCover)
        {
            coverType = "hardcover";
        }
        else
        {
            coverType = "papercover";
        }

        return $"{title} is written by {author}, published in {publicationYear}. Its price is {price} and its cover type is {coverType}";
    }
}
}
