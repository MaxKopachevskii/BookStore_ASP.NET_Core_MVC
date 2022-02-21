using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Название книги")]
        public string Name { get; set; }

        [Display(Name = "Описание к книге")]
        public string Desc { get; set; }

        [Display(Name = "Автор книги")]
        public string Author { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img { get; set; }

        [Display(Name = "Цена")]
        public int Price { get; set; }

        [Display(Name = "Издательство")]
        public string PublishHouse { get; set; }

        [Display(Name = "Год выпуска")]
        public int Year { get; set; }

        [Display(Name = "Страниц в книге")]
        public int Pages { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Артикул")]
        public int CodeBook { get; set; }

        [Display(Name = "На складе")]
        public int CountInStock { get; set; }

        [Display(Name = "Избранное")]
        public bool IsFavorite { get; set; }

        [Display(Name = "В корзине")]
        public bool InBasket { get; set; }

        [Display(Name = "Номер категории(1-Мир программирования,2-Психология,3-Худож.лит.)")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public Book()
        {
            IsFavorite = false;
            InBasket = false;
        }
    }
}
