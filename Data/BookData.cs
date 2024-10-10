using SimplyBooksBE.Models;

namespace SimplyBooksBE.Data
{
    public class BookData
    {
        public static List<Book> Books = new()
        {
            new() { Id = 1, Title = "Introduction to C#", Image = "https://example.com/images/csharp.jpg", Price = 29.99M, Sale = false, Description = "A comprehensive guide to C# programming.", AuthorId = 1, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
            new() { Id = 2, Title = "Mastering ASP.NET", Image = "https://example.com/images/aspnet.jpg", Price = 39.99M, Sale = true, Description = "Advanced concepts in ASP.NET Core development.", AuthorId = 2, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
            new() { Id = 3, Title = "JavaScript Essentials", Image = "https://example.com/images/javascript.jpg", Price = 24.99M, Sale = true, Description = "Learn the basics of JavaScript from scratch.", AuthorId = 3, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
            new() { Id = 4, Title = "React for Beginners", Image = "https://example.com/images/react.jpg", Price = 19.99M, Sale = false, Description = "An introduction to building web apps with React.", AuthorId = 4, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" }
        };
    }
}
