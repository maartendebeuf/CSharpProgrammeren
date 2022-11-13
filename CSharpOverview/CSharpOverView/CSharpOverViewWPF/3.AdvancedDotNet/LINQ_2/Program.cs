using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverViewWPF._3.AdvancedDotNet.LINQ_2
{
    internal class Program
    {
        public void Main()
        {

            List<Book> books = new List<Book>();
            books.Add(new Book { ID = 1, Name = "C# De eerste editie", PageCount = 100, Score = 5, WriterID = 1 });
            books.Add(new Book { ID = 2, Name = "C# De tweede editie", PageCount = 123, Score = 7, WriterID = 1 });
            books.Add(new Book { ID = 3, Name = "C# De derde editie", PageCount = 459, Score = 8, WriterID = 2 });
            books.Add(new Book { ID = 4, Name = "C# De vierde editie", PageCount = 285, Score = 2, WriterID = 3 });
            books.Add(new Book { ID = 5, Name = "C# De vijfde editie", PageCount = 128, Score = 3, WriterID = 2 });
            books.Add(new Book { ID = 6, Name = "C# De zesde editie", PageCount = 597, Score = 5, WriterID = 1 });

            List<Writer> writers = new List<Writer>();
            writers.Add(new Writer { ID = 1, FirstName = "Wim", LastName = "Claeys", Gender = Gender.Male, PublisherID = 1 });
            writers.Add(new Writer { ID = 2, FirstName = "Cedrick", LastName = "Vanneste", Gender = Gender.Male, PublisherID = 1 });
            writers.Add(new Writer { ID = 3, FirstName = "Els", LastName = "De smet", Gender = Gender.Female, PublisherID = 2 });

            List<Publisher> publishers = new List<Publisher>();
            publishers.Add(new Publisher() { ID = 1, Country = "België", Name = "De Standaard" });
            publishers.Add(new Publisher() { ID = 2, Country = "Nederland", Name = "VBRO" });

            //Geef een lijst terug van alle boeken met de naam van de schrijver
            var result = from book in books
                         join writer in writers on book.WriterID equals writer.ID
                         select book.Name + " - " + writer.FirstName + " " + writer.LastName;

            foreach (var item in result)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

            Console.WriteLine("Result2:");
            var result2 = books.Join(writers, book => book.WriterID, writer => writer.ID, (book, writer) => new { book, writer })
                               .Select(joinResult => joinResult.book.Name + " - " + joinResult.writer.FirstName + " " + joinResult.writer.LastName);
            foreach (var item in result2)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

            Console.WriteLine("Result3:");
            //Geef alle schrijvers terug met de naam van hun publisher
            var result3 = from writer in writers
                          join publisher in publishers on writer.PublisherID equals publisher.ID
                          select writer.FirstName + " " + writer.LastName + " - " + publisher.Name;
            foreach (var item in result3)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

            var result4 = writers.Join(publishers, writer => writer.PublisherID, publisher => publisher.ID, (writer, publisher) => new { writer, publisher })
                                 .Select(joinResult => joinResult.writer.FirstName + " " + joinResult.writer.LastName + " - " + joinResult.publisher.Name);
            Console.WriteLine("Result4:");
            foreach (var item in result4)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

            //Geef een lijst van alle boeken met de naam van het boek, het geslacht van de schrijver en het land van de publisher
            var result5 = from book in books
                          join writer in writers on book.WriterID equals writer.ID
                          join publisher in publishers on writer.PublisherID equals publisher.ID
                          select book.Name + " " + writer.Gender + " " + publisher.Country;
            Console.WriteLine("Result5:");
            foreach (var item in result5)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

            var result6 = books.Join(writers, book => book.WriterID, writer => writer.ID, (book, writer) => new { book, writer })
                               .Join(publishers, joinResult1 => joinResult1.writer.PublisherID, publisher => publisher.ID, (joinResult1, publisher) => new { joinResult1.book, joinResult1.writer, publisher })
                               .Select(joinResult2 => joinResult2.book.Name + " " + joinResult2.writer.Gender + " " + joinResult2.publisher.Country);
            Console.WriteLine("Result6:");
            foreach (var item in result6)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

        }
    }
}
