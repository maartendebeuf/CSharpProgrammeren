using OefeningenLes4_2;
using System.Globalization;

List<Movie> movies = new List<Movie>();
movies.Add(new Movie() { Name = "The Godfather", Director = "Steven Spielberg", Producer = "Roger Maes", Rating = 10, ReleaseDate = new DateTime(1972, 01, 17) });
movies.Add(new Movie() { Name = "The Shawshank Redemption", Director = "Uma Keenan", Producer = "Iman Parkinson", Rating = 5, ReleaseDate = new DateTime(2010, 03, 08) });
movies.Add(new Movie() { Name = "Schindler's List", Director = "Saif Fitzgerald", Producer = "Derrick Bate", Rating = 7, ReleaseDate = new DateTime(1993, 11, 10) });
movies.Add(new Movie() { Name = "Raging Bull", Director = "Saif Fitzgerald", Producer = "Roger Maes", Rating = 6, ReleaseDate = new DateTime(1980, 05, 08) });
movies.Add(new Movie() { Name = "Casablanca", Director = "Steven Spielberg", Producer = "Natan Foley", Rating = 4, ReleaseDate = new DateTime(2010, 12, 15) });
movies.Add(new Movie() { Name = "Citizen Kane", Director = "Michele Nelson", Producer = "Roger Maes", Rating = 7, ReleaseDate = new DateTime(1941, 07, 30) });
movies.Add(new Movie() { Name = "Gone With the Wind", Director = "Steven Spielberg", Producer = "Derrick Bate", Rating = 9, ReleaseDate = new DateTime(1939, 01, 28) });
movies.Add(new Movie() { Name = "The Wizzard of Oz", Director = "Joseph Kaur", Producer = "Roger Maes", Rating = 10, ReleaseDate = new DateTime(1975, 09, 02) });
movies.Add(new Movie() { Name = "Lawrence of Arabia", Director = "Steven Spielberg", Producer = "Derrick Bate", Rating = 5, ReleaseDate = new DateTime(2010, 06, 14) });
movies.Add(new Movie() { Name = "Vertigo", Director = "Joseph Kaur", Producer = "Edison Benton", Rating = 3, ReleaseDate = new DateTime(1958, 04, 12) });
movies.Add(new Movie() { Name = "Psycho", Director = "Nyla Gaines", Producer = "Iman Parkinson", Rating = 8, ReleaseDate = new DateTime(1960, 08, 22) });


//    ○ Toon alle films uit 2010
Console.WriteLine("Toon alle films uit 2010");
var filmsuit2010 = from movie in movies
                   where (int)movie.ReleaseDate.Year == 2010
                   select $"{movie.Name}, {movie.Producer}, {(int)movie.ReleaseDate.Year}";
foreach (var item in filmsuit2010)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var filmsuit20102 = movies.Where(movie => (int)movie.ReleaseDate.Year == 2010).Select(movie=>$"{movie.Name}, {movie.Producer}, {(int)movie.ReleaseDate.Year}");
foreach (var item in filmsuit20102)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//    ○ Toon alle films met een rating tussen 4 en 6
Console.WriteLine("Toon alle films met een rating tussen 4 en 6");
var ratingtussen4en6 = from movie in movies
                   where movie.Rating >= 4
                   where movie.Rating <= 6
                   select $"{movie.Name}, {movie.Producer}, {movie.Rating}";
foreach (var item in ratingtussen4en6)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var ratingtussen4en62 = movies.Where(movie => movie.Rating >=4).Where(movie => movie.Rating <=6).Select(movie => $"{movie.Name}, {movie.Producer}, {movie.Rating}");
foreach (var item in ratingtussen4en62)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//    ○ Toon alle films van de regiseur "Steven Spielberg"
Console.WriteLine("Toon alle films van de regiseur Steven Spielberg");
var allefilmsvanSteven = from movie in movies
                       where movie.Director == "Steven Spielberg"
                         select $"{movie.Name}, {movie.Producer}, {movie.ReleaseDate.ToString("dd/mm/yyyy")}";
foreach (var item in allefilmsvanSteven)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var allefilmsvanSteven2 = movies.Where(movie => movie.Director== "Steven Spielberg").Select(movie => $"{movie.Name}, {movie.Producer}, {movie.ReleaseDate.ToString("dd/mm/yyyy")}");
foreach (var item in allefilmsvanSteven2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//    ○ Toon het aantal films per regiseur
Console.WriteLine("Toon het aantal films per regiseur");
var aantalfilmsperregiseur = from movie in movies
                             group movie by movie.Director into movieGroup
                             select $"{movieGroup.Key}, {movieGroup.Count()}";
foreach (var item in aantalfilmsperregiseur)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var aantalfilmsperregiseur2 = movies.GroupBy(movie => movie.Director).Select(movieGroup => $"{movieGroup.Key}, {movieGroup.Count()}");
foreach (var item in aantalfilmsperregiseur2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//    ○ Toon het aantal films per producer
Console.WriteLine("Toon het aantal films per producer");
var aantalfilmsperproducer = from movie in movies
                             group movie by movie.Producer into movieGroup
                             select $"{movieGroup.Key}, {movieGroup.Count()}";
foreach (var item in aantalfilmsperproducer)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var aantalfilmsperproducer2 = movies.GroupBy(movie => movie.Producer).Select(movieGroup => $"{movieGroup.Key}, {movieGroup.Count()}");
foreach (var item in aantalfilmsperproducer2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");


//    ○ Toon de gemiddelde rating van een film voor elk jaar
Console.WriteLine("Toon de gemiddelde rating van een film voor elk jaar");
var gemiddelderating = from movie in movies
                       group movie by movie.ReleaseDate.Year into movieGroup
                       select new { year = movieGroup.Key, Count = movieGroup.Count(), Average = movieGroup.Average(movie => movie.Rating) };
foreach (var item in gemiddelderating)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var gemiddelderating2 = movies.GroupBy(movie => movie.ReleaseDate.Year)
                              .Select(movieGroup => new { year = movieGroup.Key, Count = movieGroup.Count(), Average = movieGroup.Average(movie => movie.Rating) });
                                                                     

foreach (var item in gemiddelderating2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");




Console.ReadKey();