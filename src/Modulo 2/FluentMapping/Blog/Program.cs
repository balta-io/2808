using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var posts = context.Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .ToList();
            //
            // foreach (var post in posts)
            //     Console.WriteLine($"{post.Title} by {post.Author.Name} on {post.Category.Name}");
            
            // var user = new User
            // {
            //     Name = "André Baltieri",
            //     Slug = "andre-baltieri",
            //     Email = "andre2@balta.io",
            //     Bio = "9x Microsoft MVP",
            //     Image = "https://balta.io",
            //     PasswordHash = "123098457"
            // };
            //
            // var category = new Category {Name = "Frontend", Slug = "frontend"};
            //
            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-html",
            //     Summary = "Neste artigo vamos aprender HTML",
            //     Title = "Começando com HTML",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };
            //
            // context.Posts.Add(post); // Não adicionei autor nem categoria
            // context.SaveChanges();
        }
    }
}