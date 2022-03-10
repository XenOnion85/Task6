using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book : Item
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;
        private static double price = 9;
        //public void SetBook (string author, string title, string publisher, int pages, int year)
        //{
        //    this.author = author;
        //    this.title = title;
        //    this.publisher = publisher;
        //    this.pages = pages;
        //    this.year = year;
        //}
        //public static void SetPrice(double price)
        //{
        //    Book.price = price;
        //}
       
        //public double PriceBook(int s)
        //{
        //    double cust = s * price;
        //    return cust;
        //}

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base (invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        {

        }
        static Book()
        {
            price = 10;
        }

        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public override void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n Кол-во страниц: {3} стр.\n Стоимость аренды: {4} р. в сутки", author, title, year, pages, Book.price);
            base.Show();
        }
        new public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }
        private bool returnSrok;
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return()
        {
            if (returnSrok == true) taken = true;
            else taken = false;
        }
    }
}
