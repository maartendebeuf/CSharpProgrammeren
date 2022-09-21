// See https://aka.ms/new-console-template for more information

using OefeningenLes4_1;

List<House> houses = new List<House>()
{
    new House() {Name = "Huis1", Region = "West-Vlaanderen", Price = 100000, BedroomCount = 2, Squaremeter = 50, EnumType = EnumType.Bungalow },
    new House() {Name = "Huis2", Region = "Oost-Vlaanderen", Price = 150000, BedroomCount = 3, Squaremeter = 60, EnumType = EnumType.Farm},
    new House() {Name = "Huis3", Region = "Antwerpen", Price = 180000, BedroomCount = 4, Squaremeter = 70, EnumType = EnumType.Villa },
    new House() {Name = "Huis4", Region = "Limburg", Price = 250000, BedroomCount = 5, Squaremeter = 80, EnumType = EnumType.Cottage },
    new House() {Name = "Huis5", Region = "Oost-Vlaanderen", Price = 300000, BedroomCount = 2, Squaremeter = 90, EnumType = EnumType.Farm},
    new House() {Name = "Huis6", Region = "Limburg", Price = 150000, BedroomCount = 3, Squaremeter = 100, EnumType = EnumType.Bungalow },
    new House() {Name = "Huis7", Region = "Antwerpen", Price = 190000, BedroomCount = 4, Squaremeter = 150, EnumType = EnumType.Bungalow },
    new House() {Name = "Huis8", Region = "West-Vlaanderen", Price = 200000, BedroomCount = 5, Squaremeter = 100, EnumType = EnumType.Villa},
    new House() {Name = "Huis9", Region = "Limburg", Price = 100000, BedroomCount = 2, Squaremeter = 115, EnumType = EnumType.Cottage },
    new House() {Name = "Huis10", Region = "West-Vlaanderen", Price = 500000, BedroomCount = 4, Squaremeter = 55, EnumType = EnumType.Farm},
    new House() {Name = "Huis11", Region = "Limburg", Price = 120000, BedroomCount = 6, Squaremeter = 62, EnumType = EnumType.Cottage},
    new House() {Name = "Huis12", Region = "Antwerpen", Price = 200000, BedroomCount = 2, Squaremeter = 70, EnumType = EnumType.Bungalow },
    new House() {Name = "Huis13", Region = "Oost-Vlaanderen", Price = 150000, BedroomCount = 3, Squaremeter = 80, EnumType = EnumType.Bungalow },
    new House() {Name = "Huis14", Region = "West-Vlaanderen", Price = 190000, BedroomCount = 1, Squaremeter = 90, EnumType = EnumType.Farm },
    new House() {Name = "Huis15", Region = "Antwerpen", Price = 300000, BedroomCount = 5, Squaremeter = 100, EnumType = EnumType.Cottage},
    new House() {Name = "Huis16", Region = "West-Vlaanderen", Price = 250000, BedroomCount = 4, Squaremeter = 110, EnumType = EnumType.Villa}
};



//toon het aantal huizen per regio
Console.WriteLine("toon het aantal huizen per regio");
var HouseCount1 = from house in houses
                 group house by house.Region into houseGroup
                 select houseGroup.Key + ": " + houseGroup.Count();
foreach (var item in HouseCount1)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var HouseCount2 = houses.GroupBy(house => house.Region)
                        .Select(houseGroup => houseGroup.Key + ": " + houseGroup.Count());
foreach (var item in HouseCount2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//toon per huis het aantal slaapkamers
Console.WriteLine("toon per huis het aantal slaapkamers");
var bedroomCount = from house in houses
                   select house.Name + ": " + house.BedroomCount + "slaapkamers";
foreach (var item in bedroomCount)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var bedroomCount2 = houses.Select(house => house.Name + ": " + house.BedroomCount + "slaapkamers");
foreach (var item in bedroomCount2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//toon het aantal huizen per type
Console.WriteLine("toon het aantal huizen per type");
var HuisTypes = from house in houses
                group house by house.EnumType into houseGroup
                select houseGroup.Key + ": " + houseGroup.Count();
foreach (var item in HuisTypes)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var huisTypes2 = houses.GroupBy(house => house.EnumType).Select(houseGroup => houseGroup.Key + ": " + houseGroup.Count());
foreach (var item in huisTypes2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//toon alle huizen met meer dan 100m² oppervlakte
Console.WriteLine("toon alle huizen met meer dan 100m² oppervlakte");
var huizenDuurderDanHonderd = from house in houses
                              where house.Squaremeter > 100
                              select house.Squaremeter;
foreach (var item in huizenDuurderDanHonderd)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var huizenDuurderDanHonderd2 = houses.Where(house => house.Squaremeter > 100).Select(HouseGroup => HouseGroup.Squaremeter);
foreach (var item in huizenDuurderDanHonderd2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//toon het aantal huizen per prijs ( in stapen van 50000) indien de stap niet bestaat hoeft deze niet getoond te worden
Console.WriteLine("toon het aantal huizen per prijs in stapen van 50000");
var huizenPrijsGoepering = from house in houses
                           orderby house.Price
                           group house by (int)house.Price/50000 into houseGroup
                           select string.Format("{0}-{1}: {2} huizen", houseGroup.Key*50000, (houseGroup.Key+1) * 50000, houseGroup.Count());
foreach (var item in huizenPrijsGoepering)
{
    Console.WriteLine(item);
}
Console.WriteLine("");


Console.WriteLine("Stap2");
var huizenPrijsGoepering2 = houses  .OrderBy(house => house.Price)
                                    .GroupBy(house => (int)house.Price / 50000)
                                    .Select(houseGroup => $"{houseGroup.Key*50000}-{(houseGroup.Key+1) * 50000}: {houseGroup.Count()} huizen");
foreach (var item in huizenPrijsGoepering2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");



//toon de huizen met hun naam, prijs en type
Console.WriteLine("toon de huizen met hun naam, prijs en type");
var huizenlijst = from house in houses
                  select house.Name + ", " + house.Price + ", " + house.EnumType;
foreach (var item in huizenlijst)
{
    Console.WriteLine(item);
}
Console.WriteLine("");

Console.WriteLine("Stap2");
var huizenlijst2 = houses.Select(house => house.Name + ", " + house.Price + ", " + house.EnumType);
foreach (var item in huizenlijst2)
{
    Console.WriteLine(item);
}
Console.WriteLine("");




Console.ReadKey();