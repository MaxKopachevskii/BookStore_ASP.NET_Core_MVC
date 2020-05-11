using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Название категории")]
        public string Name { get; set; }

        [Display(Name = "Описание категории")]
        public string ShortDesc { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }

        public Category()
        {
            Books = new List<Book>();
        }
    }
}
