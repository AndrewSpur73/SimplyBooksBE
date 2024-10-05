using SimplyBooksBE.Models;

namespace SimplyBooksBE.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new()
        {
            new() { Id = 1, FirstName = "Emily", LastName = "Turner", Email = "emily.turner@example.com", Image = "https://example.com/images/emily.jpg", Favorite = false, Uid = "a1b2c3d4e5f6" },
            new() { Id = 2, FirstName = "Michael", LastName = "Smith", Email = "michael.smith@example.com", Image = "https://example.com/images/michael.jpg", Favorite = true, Uid = "b7c8d9e0f1g2" },
            new() { Id = 3, FirstName = "Olivia", LastName = "Johnson", Email = "olivia.johnson@example.com", Image = "https://example.com/images/olivia.jpg", Favorite = false, Uid = "h3i4j5k6l7m8" },
            new() { Id = 4, FirstName = "James", LastName = "Williams", Email = "james.williams@example.com", Image = "https://example.com/images/james.jpg", Favorite = true, Uid = "n9o0p1q2r3s4" }
        };
    }
}