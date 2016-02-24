using System;
using System.Text.RegularExpressions;
public class EnterBookDetailsAndDisplayDetails
{
  public static void Main(string[] args)
  {
    String _bookTitle,_author;
    String _priceCheck;
    double _price = 0;

    Console.Write("Enter book title: ");
    _bookTitle = Console.ReadLine();
            
    Console.Write("Enter author of a book: ");
    _author = Console.ReadLine();
    bool isAllLetters = Regex.IsMatch(_author, @"^[a-zA-Z]+$");
    if (isAllLetters)
    {
       Console.Write("Enter price for a book: ");
       _priceCheck = Console.ReadLine();
       if (double.TryParse(_priceCheck, out _price))
       {
          Print(_bookTitle, _author, _price);
       }
       else
       {
          Console.WriteLine("The price \"{0}\" that you have entered is incorrect", _priceCheck);
       }
     }
     else
     {
        Console.WriteLine("The author \"{0}\" that you have entered is Invalid",_author);
     }        
  }
  public static void Print(String bookTitle, String author, double price)
  {
    bookTitle = bookTitle.ToUpper();
    author = author.ToLower();

    Console.WriteLine(@"Book Title: " + "\"{0}\"" + "\nAuthor: {1}" + "\nPrice: {2}Є", bookTitle, author, price);
  }
}

