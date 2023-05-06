using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        private bool CheckedOut;
        public List<User> BookHistory { get; set; }
    }
}