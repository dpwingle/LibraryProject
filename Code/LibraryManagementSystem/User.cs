using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public class User
    {
        public bool Librarian { get; set; }
        private List<Book> CurrentCheckedOutBooks;
        private List<Book> BookHistory;
        private decimal lateFeesDue;
        public string Username { get; set; }

        private string password;

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        public decimal getLateFees()
        {
            return lateFeesDue;
        }

        public void PayLateFees(decimal paymentAmount)
        {
            if (paymentAmount <= this.lateFeesDue && paymentAmount > 0) 
            {
                this.lateFeesDue = this.lateFeesDue - paymentAmount;
            }            
            else
            {
                //return error
            }
        }

        public List<Book> GetUsersCheckedOutBooks()
        {
            return this.CurrentCheckedOutBooks;
        }

        public void UserCheckedOutBook(Book book)
        {
            this.CurrentCheckedOutBooks.Add(book);
            this.BookHistory.Add(book);
        }

        public void UserCheckedInBook(Book book)
        {
            this.CurrentCheckedOutBooks.Remove(book);
        }
    }
}
