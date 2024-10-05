<h1 align="center" style="font-weight: bold;">SimplyBooksBE 💻</h1>

<p align="center">
 <a href="#tech">Technologies</a> • 
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> •
</p>

<p align="center">
    <b>The SimplyBooks API provides endpoints for managing authors and their books. This collection allows users to retrieve, create, update, and delete both books and authors. It is designed to facilitate interactions with a collection of books and their respective authors in an organized and user-friendly way.</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- C#
- .NET
- SQL
- Postman

<h2 id="started">🚀 Getting started</h2>

1.) Clone a repository option in Visual Studio
2.) Enter or type the repository location, and then select the Clone button
3.) To start building the program, press the green Start button on the Visual Studio toolbar, or press F5 or Ctrl+F5. Using the Start button or F5 runs the program under the debugger.

<h3>Prerequisites</h3>

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

<h3>Postman Documentation</h3>
- [API Documentation](https://documenter.getpostman.com/view/31982709/2sAXxMfteM)

<h3>Cloning</h3>

How to clone your project

```bash
git clone git@github.com:AndrewSpur73/SimplyBooksBE.git
```

<h3>Starting</h3>

```bash
cd SimplyBooksBE
dotnet watch run
```
​
<h2 id="routes">📍 API Endpoints</h2>

| Route                        | Description                                                         |
|-------------------------------|---------------------------------------------------------------------|
| <kbd>GET /authors</kbd>        | Retrieves authors [response details](#get-author)                   |
| <kbd>GET /authors/{id}</kbd>   | Retrieves individual author by ID [response details](#get-authorid) |
| <kbd>POST /authors</kbd>       | Create a new author [request details](#post-author)                 |
| <kbd>PUT /authors/{id}</kbd>   | Update an author [request details](#put-author)                     |
| <kbd>DELETE /authors/{id}</kbd>| Delete an author [request details](#delete-author)                 |
| <kbd>GET /books</kbd>          | Retrieves books [response details](#get-book)                       |
| <kbd>GET /books/{id}</kbd>     | Retrieves individual book by ID [response details](#get-bookid)     |
| <kbd>POST /books</kbd>         | Create a new book [request details](#post-book)                     |
| <kbd>PUT /books/{id}</kbd>     | Update a book [request details](#put-book)                         |
| <kbd>DELETE /books/{id}</kbd>  | Delete a book [request details](#delete-book)                      |


<h3 id="get-author">GET /authors</h3>

**RESPONSE**
```json
    {
        "id": 1,
        "firstName": "Emily",
        "lastName": "Turner",
        "email": "emily.turner@example.com",
        "image": "https://example.com/images/emily.jpg",
        "favorite": false,
        "uid": "a1b2c3d4e5f6",
        "books": null
    },
    {
        "id": 2,
        "firstName": "Michael",
        "lastName": "Smith",
        "email": "michael.smith@example.com",
        "image": "https://example.com/images/michael.jpg",
        "favorite": true,
        "uid": "b7c8d9e0f1g2",
        "books": null
    },
    {
        "id": 3,
        "firstName": "Olivia",
        "lastName": "Johnson",
        "email": "olivia.johnson@example.com",
        "image": "https://example.com/images/olivia.jpg",
        "favorite": false,
        "uid": "h3i4j5k6l7m8",
        "books": null
    },
    {
        "id": 4,
        "firstName": "James",
        "lastName": "Williams",
        "email": "james.williams@example.com",
        "image": "https://example.com/images/james.jpg",
        "favorite": true,
        "uid": "n9o0p1q2r3s4",
        "books": null
    }
```

<h3 id="get-authorid">GET /authors/id</h3>

**RESPONSE**
```json
{
    "id": 1,
    "firstName": "Emily",
    "lastName": "Turner",
    "email": "emily.turner@example.com",
    "image": "https://example.com/images/emily.jpg",
    "favorite": false,
    "uid": "a1b2c3d4e5f6",
    "books": [
        {
            "id": 1,
            "title": "Introduction to C#",
            "image": "https://example.com/images/csharp.jpg",
            "price": 29.99,
            "sale": false,
            "description": "A comprehensive guide to C# programming.",
            "authorId": 1,
            "uid": "book12345",
            "author": null
        }
    ]
}
```
<h3 id="post-author">POST /authors</h3>

**REQUEST**
```json
   { 
    "firstName": "Bob",
    "lastName": "Ross",
    "email": "bob.ross@example.com",
    "image": "https://example.com/images/bob.jpg",
    "favorite": true
   }
```

**RESPONSE**
```json
  {
    "id": 5,
    "firstName": "Bob",
    "lastName": "Ross",
    "email": "bob.ross@example.com",
    "image": "https://example.com/images/bob.jpg",
    "favorite": true,
    "uid": null,
    "books": null
  }
```

<h3 id="put-author">PUT /authors/id</h3>

**REQUEST**
```json
{
    "id": 5,
    "firstName": "Bobby",
    "lastName": "Rossy",
    "email": "bob.ross@example.com",
    "image": "https://example.com/images/bob.jpg",
    "favorite": true,
    "uid": null,
    "books": null
}
```

**RESPONSE**
```json
{
    "id": 5,
    "firstName": "Bobby",
    "lastName": "Rossy",
    "email": "bob.ross@example.com",
    "image": "https://example.com/images/bob.jpg",
    "favorite": true,
    "uid": null,
    "books": null
}
```

<h3 id="get-authorid">DELETE /authors/id</h3>

**RESPONSE**
- No content

<h3 id="get-book">GET /books</h3>

**RESPONSE**
```json
    {
        "id": 1,
        "title": "Introduction to C#",
        "image": "https://example.com/images/csharp.jpg",
        "price": 29.99,
        "sale": false,
        "description": "A comprehensive guide to C# programming.",
        "authorId": 1,
        "uid": "book12345",
        "author": null
    },
    {
        "id": 2,
        "title": "Mastering ASP.NET",
        "image": "https://example.com/images/aspnet.jpg",
        "price": 39.99,
        "sale": true,
        "description": "Advanced concepts in ASP.NET Core development.",
        "authorId": 2,
        "uid": "book67890",
        "author": null
    },
    {
        "id": 3,
        "title": "JavaScript Essentials",
        "image": "https://example.com/images/javascript.jpg",
        "price": 24.99,
        "sale": true,
        "description": "Learn the basics of JavaScript from scratch.",
        "authorId": 3,
        "uid": "book24680",
        "author": null
    },
    {
        "id": 4,
        "title": "React for Beginners",
        "image": "https://example.com/images/react.jpg",
        "price": 19.99,
        "sale": false,
        "description": "An introduction to building web apps with React.",
        "authorId": 4,
        "uid": "book11223",
        "author": null
    }
```

<h3 id="get-bookid">GET /books/id</h3>

**RESPONSE**
```json
{
    "id": 1,
    "title": "Introduction to C#",
    "image": "https://example.com/images/csharp.jpg",
    "price": 29.99,
    "sale": false,
    "description": "A comprehensive guide to C# programming.",
    "authorId": 1,
    "uid": "book12345",
    "author": {
        "id": 1,
        "firstName": "Emily",
        "lastName": "Turner",
        "email": "emily.turner@example.com",
        "image": "https://example.com/images/emily.jpg",
        "favorite": false,
        "uid": "a1b2c3d4e5f6",
        "books": [
            null
        ]
    }
}
```
<h3 id="post-book">POST /books</h3>

**REQUEST**
```json
   { 
    "title": "Introduction to Coding",
    "image": "https://example.com/images/coding.jpg",
    "price": 99.99,
    "sale": true,
    "description": "A comprehensive guide to coding programming.",
    "authorId": 1
   }
```

**RESPONSE**
```json
{
    "id": 5,
    "title": "Introduction to Coding",
    "image": "https://example.com/images/coding.jpg",
    "price": 99.99,
    "sale": true,
    "description": "A comprehensive guide to coding programming.",
    "authorId": 1,
    "uid": null,
    "author": null
}
```

<h3 id="put-book">PUT /books/id</h3>

**REQUEST**
```json
{
    "id": 5,
    "title": "Introduction to Coding",
    "image": "https://example.com/images/coding.jpg",
    "price": 109.99,
    "sale": true,
    "description": "A comprehensive guide to coding programming.",
    "authorId": 1,
    "uid": null,
    "author": null
}
```

**RESPONSE**
```json
{
    "id": 5,
    "title": "Introduction to Coding",
    "image": "https://example.com/images/coding.jpg",
    "price": 109.99,
    "sale": true,
    "description": "A comprehensive guide to coding programming.",
    "authorId": 1,
    "uid": null,
    "author": null
}
```

<h3 id="get-bookid">DELETE /books/id</h3>

**RESPONSE**
- No content

