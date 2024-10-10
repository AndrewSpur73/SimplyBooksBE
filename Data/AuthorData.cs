using SimplyBooksBE.Models;

namespace SimplyBooksBE.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new()
        {
            new() { Id = 1, FirstName = "Emily", LastName = "Turner", Email = "emily.turner@example.com", Image = "https://example.com/images/emily.jpg", Favorite = false, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
            new() { Id = 2, FirstName = "Michael", LastName = "Smith", Email = "michael.smith@example.com", Image = "https://example.com/images/michael.jpg", Favorite = true, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
            new() { Id = 3, FirstName = "Olivia", LastName = "Johnson", Email = "olivia.johnson@example.com", Image = "https://example.com/images/olivia.jpg", Favorite = false, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" },
            new() { Id = 4, FirstName = "James", LastName = "Williams", Email = "james.williams@example.com", Image = "https://example.com/images/james.jpg", Favorite = true, Uid = "3HLd4GH2OrYYJ1eAUWEqFcixcK02" }
        };
    }
}