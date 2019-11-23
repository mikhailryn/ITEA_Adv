using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PractAdv8;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BookShelfContext book = new BookShelfContext())
            {
                
                var character = new Character();
                //Добавление в БД модели персонажей
                book.Characters.Add(character);

                var bookService = new BookShelfService();

                //Вызов метода заполнения таблицы персонажами
                bookService.AddCharacterBookShelf();

                //Вывод персонажей в консоль
                bookService.GetBookShelf();

                //Вставка записи в таблицу Movies
                bookService.AddMovies();
            }
        }
    }
}
