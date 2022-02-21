using System.Collections.Generic;

namespace ASP.NET_Core_BookStore.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public string Search { get; set; }
    }
}
