using Microsoft.EntityFrameworkCore;
using SimplyBooksBE.Models;

namespace SimplyBooksBE.API
{
    public class BookAPI
    {
        public static void Map(WebApplication app)
        {
            // get books
            app.MapGet("/books", (SimplyBooksBEDbContext db) =>
            {
                return db.Books.ToList();
            });

            // get a single book
            app.MapGet("/books/{id}", (SimplyBooksBEDbContext db, int id) =>
            {
                Book book = db.Books
                                .Include(book => book.Author)
                                .SingleOrDefault(book => book.Id == id);

                if (book == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(book);
            });

            // create book
            app.MapPost("/books", (SimplyBooksBEDbContext db, Book newBook) =>
            {
                db.Books.Add(newBook);
                db.SaveChanges();
                return Results.Created($"books/{newBook.Id}", newBook);
            });

            // update book
            app.MapPut("/books/{id}", (SimplyBooksBEDbContext db, int id, Book book) =>
            {
                Book bookToUpdate = db.Books.SingleOrDefault(book => book.Id == id);

                if (bookToUpdate == null)
                {
                    return Results.NotFound();
                }

                bookToUpdate.Title = book.Title;
                bookToUpdate.Image = book.Image;
                bookToUpdate.Price = book.Price;
                bookToUpdate.Sale = book.Sale;
                bookToUpdate.Description = book.Description;

                db.SaveChanges();
                return Results.Ok(bookToUpdate);
            });

            // delete book
            app.MapDelete("/books/{id}", (SimplyBooksBEDbContext db, int id) =>
            {
                Book book = db.Books.SingleOrDefault(book => book.Id == id);

                if (book == null)
                {
                    return Results.NotFound();
                }

                db.Books.Remove(book);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
