using LibraryManagementSystem;

namespace NUnitTesting
{
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            Book book = new Book("The Lord of the Rings", "J.R.R. Tolkien", "039502641X");

            // Act
            library.AddBook(book);

            // Assert
            Assert.That(library.Books, Has.Count.EqualTo(1));
            Assert.That(library.Books.Contains(book), Is.True);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrowerToLibrary()
        {
            Borrower borrower = new Borrower("John Doe", "12345");

            // Act
            library.RegisterBorrower(borrower);

            // Assert
            Assert.That(library.Borrowers, Has.Count.EqualTo(1));
            Assert.That(library.Borrowers.Contains(borrower), Is.True);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowedAndAssociateWithBorrower()
        {
            Book book = new Book("The Hobbit", "J.R.R. Tolkien", "0261103882");
            Borrower borrower = new Borrower("Jane Doe", "54321");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            // Act
            library.BorrowBook(book.ISBN, borrower.LibraryCardNumber);

            // Assert
            Assert.That(book.IsBorrowed, Is.True);
            Assert.That(borrower.BorrowedBooks, Contains.Item(book));
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailableAndRemoveFromBorrower()
        {
            Book book = new Book("The Hobbit", "J.R.R. Tolkien", "0261103882");
            Borrower borrower = new Borrower("Jane Doe", "54321");
            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook(book.ISBN, borrower.LibraryCardNumber); // Borrow the book first

            // Act
            library.ReturnBook(book.ISBN, borrower.LibraryCardNumber);

            // Assert
            Assert.That(book.IsBorrowed, Is.False);
            Assert.That(borrower.BorrowedBooks, Is.Empty);
        }

        [Test]
        public void ViewBooks_ShouldReturnListOfBooks()
        {
            Book book1 = new Book("Book1", "Author1", "ISBN1");
            Book book2 = new Book("Book2", "Author2", "ISBN2");
            library.AddBook(book1);
            library.AddBook(book2);

            // Act
            List<Book> books = library.ViewBooks();

            // Assert
            Assert.That(books, Has.Count.EqualTo(2));
            Assert.That(books.Contains(book1), Is.True);
            Assert.That(books.Contains(book2), Is.True);
        }

        [Test]
        public void ViewBorrowers_ShouldReturnListOfBorrowers()
        {
            Borrower borrower1 = new Borrower("John Doe", "12345");
            Borrower borrower2 = new Borrower("Jane Doe", "54321");
            library.RegisterBorrower(borrower1);
            library.RegisterBorrower(borrower2);

            // Act
            List<Borrower> borrowers = library.ViewBorrowers();

            // Assert
            Assert.That(borrowers, Has.Count.EqualTo(2));
            Assert.That(borrowers.Contains(borrower1), Is.True);
            Assert.That(borrowers.Contains(borrower2), Is.True);
        }

    }
}