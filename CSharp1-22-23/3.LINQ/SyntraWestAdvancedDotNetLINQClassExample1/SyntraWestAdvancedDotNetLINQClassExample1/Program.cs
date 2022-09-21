// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SyntraWestAdvancedDotNetLINQClassExample1;

List<Course> courses = new List<Course>() {
    new Course() { Duration = 10, Period = EnumPeriod.Day, Room = "F30", StudentCount = 10, Teacher = "Arne" },
    new Course() { Duration = 14, Period = EnumPeriod.Day, Room = "F31", StudentCount = 15, Teacher = "Wim" },
    new Course() { Duration = 24, Period = EnumPeriod.Evening, Room = "F32", StudentCount = 14, Teacher = "Nico" },
    new Course() { Duration = 35, Period = EnumPeriod.Evening, Room = "F30", StudentCount = 14, Teacher = "Jan" },
    new Course() { Duration = 15, Period = EnumPeriod.Day, Room = "F31", StudentCount = 17, Teacher = "Arne" },
    new Course() { Duration = 22, Period = EnumPeriod.Evening, Room = "F32", StudentCount = 25, Teacher = "Jan" },
    new Course() { Duration = 11, Period = EnumPeriod.Day, Room = "F30", StudentCount = 12, Teacher = "Nico" },
    new Course() { Duration = 47, Period = EnumPeriod.Evening, Room = "F33", StudentCount = 18, Teacher = "Arne" },
    new Course() { Duration = 8, Period = EnumPeriod.Day, Room = "F30", StudentCount = 10, Teacher = "Wim" },
};

//Toon alle cursussen met minimaal 15 studenten
var coursesFiltered = from course in courses
                      where course.StudentCount >= 15
                      select course;

var coursesFiltered2 = courses.Where(course => course.StudentCount >= 15);

//Toon alle cursussen die overdag plaatsvinden
var coursesFiltered3 = from course in courses
                       where course.Period == EnumPeriod.Day
                       select course;

var coursesFiltered4 = courses.Where(course => course.Period == EnumPeriod.Day);

//Toon het aantal cursussen per docent (groepering)
var coursesGrouped1 = from course in courses
                      group course by course.Teacher into courseGroup
                      select courseGroup.Key + ": " + courseGroup.Count();
//select courseGroup;

foreach (var item in coursesGrouped1)
{
    Console.WriteLine(item + Environment.NewLine);
}

Console.WriteLine("Part2:");
var coursesGrouped2 = courses.GroupBy(course => course.Teacher)
                             .Select(courseGroup => courseGroup.Key + ": " + courseGroup.Count());
foreach (var item in coursesGrouped2)
{
    Console.WriteLine(item + Environment.NewLine);
}

//Toon alle cursussen met de docent, de locatie en de duurtijd
Console.WriteLine("Toon alle cursussen met de docent, de locatie en de duurtijd...");
var coursesSelect1 = from course in courses
                     select course.Teacher + " - " + course.Room + " - " + course.Duration;
foreach (var item in coursesSelect1)
{
    Console.WriteLine(item + Environment.NewLine);
}

Console.WriteLine("Part2:");
var coursesSelect2 = courses.Select(course => course.Teacher + " - " + course.Room + " - " + course.Duration);
foreach (var item in coursesSelect2)
{
    Console.WriteLine(item + Environment.NewLine);
}

Console.WriteLine("Toon het aantal cursussen per periode (groepering)");
//Toon het aantal cursussen per periode (groepering)
var coursesGrouping3 = from course in courses
                       group course by course.Period into courseGrouping2
                       select courseGrouping2.Key + ": " + courseGrouping2.Count();

foreach (var item in coursesGrouping3)
{
    Console.WriteLine(item + Environment.NewLine);
}

Console.WriteLine("part 2:");
var coursesGrouping4 = courses.GroupBy(course => course.Period)
                              .Select(courseGroup => courseGroup.Key + ":" + courseGroup.Count());
foreach (var item in coursesGrouping4)
{
    Console.WriteLine(item + Environment.NewLine);
}

Console.ReadKey();