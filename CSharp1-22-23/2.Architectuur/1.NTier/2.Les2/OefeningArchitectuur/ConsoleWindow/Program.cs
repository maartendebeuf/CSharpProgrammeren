﻿

Console.WriteLine("Hello, World!");
Logic.Logic logic = new Logic.Logic();
var files = logic.ReadFolder();
int i = 1;
foreach (var file in files)
{
    Console.WriteLine(i.ToString() + "; " + file);
    i++;
}
Console.WriteLine("\n");
Console.WriteLine("Enter filenumber to read");


var fileNumber = int.Parse(Console.ReadLine());

var fileText = logic.ReadTxtFile(files[fileNumber - 1]);

foreach (var line in fileText)
{
    Console.WriteLine(line);

}
Console.ReadLine();