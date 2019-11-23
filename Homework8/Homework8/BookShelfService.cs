using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PractAdv8;
using PractAdv8.Models;

namespace Homework8
{
    public class BookShelfService
    {
       public void AddBookShelf()
        {
            var book = new BookShelfContext();
            var characters = CinemaService.GetCharacters();

            foreach (var charactert in characters)
            {
                book.Characters.Add(charactert);
            }
            book.SaveChanges();
        }
        public void GetBookShelf()
        {
            var book = new BookShelfContext();
                 
            foreach(var c in book.Characters)
            {
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}    \tGender: {c.Gender}  \tAge: {c.Age}");
            }
        }
        public void AddCharacterBookShelf()
        {
            var book = new BookShelfContext();
            var characterOne = new Character()
            {FirstName = "Emmmett", LastName = "Brown", Gender = true, Age = 64 };
            var characterTwo = new Character()
            {FirstName = "Marty", LastName = "McFly", Gender = true, Age = 24 };
            book.Characters.Add(characterOne);
            book.Characters.Add(characterTwo);
            book.SaveChanges();
            Console.WriteLine($"Characters {characterOne.FirstName},{characterTwo.FirstName} added");
        }
        public void AddMovies()
        {
            var book = new BookShelfContext();

            var movie = new Movie()
            {Id = 1, Name = "Star Wars", Genre = "science fiction", Year = 1999};
            book.Movies.Add(movie);
            book.SaveChanges();
            Console.WriteLine($"Movie: {movie.Name} added");
        }
    }
}
