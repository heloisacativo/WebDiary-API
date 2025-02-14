using WebDiary_API.Data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore; // Add this using directive

var builder = WebApplication.CreateBuilder(args);
Env.Load();
builder.Configuration.AddEnvironmentVariables();


// Add services to the container.

builder.Services.AddControllers();
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")
                ?? builder.Configuration.GetConnectionString("Database");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



//namespace IEnumerableDemo
//{
//    public class Book
//    {
//        public string Title { get; set; }
//    }

//    public class Library
//    {
//        public void PrintBookTitles(IEnumerable<string> bookTitles)
//        {
//            foreach (string title in bookTitles)
//            {
//                Console.WriteLine(title);
//            }
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Library library = new Library();
//            List<string> bookList = new List<string> { "1984", "To Kill a Mockingbird", "The Great Gatsby"};
//            string[] bookArray = { "1984", "To Kill a Mockingbird", "The GreatGatsby" };


//            Console.WriteLine("Book titles from List:");
//            library.PrintBookTitles(bookList);

//            Console.WriteLine("\nBook titles from array");
//            library.PrintBookTitles(bookArray);
//            Console.ReadKey();
//        }
//    }
//}