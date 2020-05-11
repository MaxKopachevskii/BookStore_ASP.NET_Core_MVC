using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Отдиление новой почты")]
        public int Post { get; set; }

        [Display(Name = "Комментарий к заказу")]
        public string Comment { get; set; }

        [Display(Name = "Дата заказа")]
        public DateTime Date { get; set; }

        [Display(Name = "Артикул заказаного товара")]
        public int CodeBook { get; set; }

        [Display(Name = "ID заказаной книги")]
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public Order()
        {
            Date = DateTime.Now;
        }
    }
}
