using Microsoft.EntityFrameworkCore;
using SimplyBooksBE.Models;

namespace SimplyBooksBE.API
{
    public class AuthorAPI
    {
        public static void Map(WebApplication app)
        {
            // get all authors
            app.MapGet("/authors", (SimplyBooksBEDbContext db) =>
            {
                return db.Authors.ToList();
            });

            // get a single author
            app.MapGet("/authors/{id}", (SimplyBooksBEDbContext db, int id) =>
            {
                Author author = db.Authors
                                .Include(author => author.Books)
                                .SingleOrDefault(author => author.Id == id);

                if (author == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(author);
            });

            // create author
            app.MapPost("/authors", (SimplyBooksBEDbContext db, Author newAuthor) =>
            {
                db.Authors.Add(newAuthor);
                db.SaveChanges();
                return Results.Created($"authors/{newAuthor.Id}", newAuthor);
            });

            // update author
            app.MapPut("/authors/{id}", (SimplyBooksBEDbContext db, int id, Author author) =>
            {
                Author authorToUpdate = db.Authors.SingleOrDefault(author => author.Id == id);

                if (authorToUpdate == null)
                {
                    return Results.NotFound();
                }

                authorToUpdate.FirstName = author.FirstName;
                authorToUpdate.LastName = author.LastName;
                authorToUpdate.Email = author.Email;
                authorToUpdate.Image = author.Image;
                authorToUpdate.Favorite = author.Favorite;

                db.SaveChanges();
                return Results.Ok(authorToUpdate);
            });

            // delete author
            app.MapDelete("/authors/{id}", (SimplyBooksBEDbContext db, int id) =>
            {
                Author author = db.Authors.SingleOrDefault(author => author.Id == id);

                if (author == null)
                {
                    return Results.NotFound();
                }

                db.Authors.Remove(author);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
