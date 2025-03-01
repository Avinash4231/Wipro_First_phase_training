using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            Book bookToBorrow = Books.FirstOrDefault(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (bookToBorrow != null && borrower != null && !bookToBorrow.IsBorrowed)
            {
                bookToBorrow.Borrow();
                borrower.BorrowBook(bookToBorrow);
            }
            else
            {
                // Handle invalid borrow request (e.g., book not found, borrower not found, book already borrowed)
                // You can throw an exception or display an error message
            }
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            Book bookToReturn = Books.FirstOrDefault(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (bookToReturn != null && borrower != null && bookToReturn.IsBorrowed)
            {
                bookToReturn.Return();
                borrower.ReturnBook(bookToReturn);
            }
            else
            {
                // Handle invalid return request (e.g., book not found, borrower not found, book not borrowed)
                // You can throw an exception or display an error message
            }
        }

        public List<Book> ViewBooks()
        {
            return Books;
        }

        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }
}
