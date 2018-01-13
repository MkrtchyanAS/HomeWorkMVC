using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HomeMVC.Models
{
    public class BookDbInitializer :DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 350 });
            db.Books.Add(new Book { Name = "Generation П", Author = "В. Пелевин", Price = 300 });
            db.Books.Add(new Book { Name = "Колыбель для кошки", Author = "К. Воннегут", Price = 310 });
            base.Seed(db);
        }
    }
}