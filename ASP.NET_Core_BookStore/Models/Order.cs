﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_BookStore.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа")]
        public int Id { get; set; }

        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Отделение новой почты")]
        public int Post { get; set; }

        [Display(Name = "Комментарий к заказу")]
        public string Comment { get; set; }

        [Display(Name = "Дата заказа")]
        public DateTime Date { get; set; }

        public IEnumerable<Book> OrderBooks { get; set; }
        public Order()
        {
            OrderBooks = new List<Book>();
            Date = DateTime.Now;
        }
    }
}
