////● Maak de klasse Product
////    ○ Properties: ID, Weight, BoxID
////● Maak de klasse Box
////    ○ Properties: ID, TareWeight, Size
////● Maak de klasse Pallet
////    ○ Properties: ID, TareWeight, Name, Type
//● Maak demo data aan voor alle klasses om onderstaande queries te kunnen
//aanmaken
//● Maak volgende LINQ queries
//    ○ selecteer alle producten met hun gewicht, het doos gewicht en het pallet gewicht
//    ○ selecteer alle producten die op een pallet staan van het type 'standaard'
//    ○ Bereken het totale gewicht per doos (Box)

using OefeningenLes4_5;

List<Product> products = new List<Product>();
List<Box> boxes = new List<Box>();
List<Pallet> pallets = new List<Pallet>();

#region AddFields
products.Add(new Product() { ID = 1, Weight = 0.4, BoxID = 5 });
products.Add(new Product() { ID = 2, Weight = 4, BoxID = 1 });
products.Add(new Product() { ID = 3, Weight = 1.24, BoxID = 2 });
products.Add(new Product() { ID = 4, Weight = 0.6, BoxID = 2 });
products.Add(new Product() { ID = 5, Weight = 1, BoxID = 3 });
products.Add(new Product() { ID = 6, Weight = 1.4, BoxID = 5 });
products.Add(new Product() { ID = 7, Weight = 2.8, BoxID = 4 });
products.Add(new Product() { ID = 8, Weight = 3, BoxID = 3 });
products.Add(new Product() { ID = 9, Weight = 2.4, BoxID = 1 });
products.Add(new Product() { ID = 10, Weight = 1.5, BoxID = 2 });


boxes.Add(new Box() { ID = 1, TareWeight = 2.0, Size = "L", PalletID = 1});
boxes.Add(new Box() { ID = 2, TareWeight = 1.2, Size = "S", PalletID = 3 });
boxes.Add(new Box() { ID = 3, TareWeight = 5.2, Size = "M", PalletID = 5 });
boxes.Add(new Box() { ID = 4, TareWeight = 2.6, Size = "L", PalletID = 1 });
boxes.Add(new Box() { ID = 5, TareWeight = 6, Size = "XS", PalletID = 2 });
boxes.Add(new Box() { ID = 6, TareWeight = 1.9, Size = "XS", PalletID = 3 });
boxes.Add(new Box() { ID = 7, TareWeight = 3.5, Size = "L", PalletID = 5 });


pallets.Add(new Pallet() { ID = 1, TareWeight = 10, Name = "One", Type = "Standaard" });
pallets.Add(new Pallet() { ID = 2, TareWeight = 11, Name = "Two", Type = "Half" });
pallets.Add(new Pallet() { ID = 3, TareWeight = 15, Name = "Three", Type = "Standaard" });
pallets.Add(new Pallet() { ID = 4, TareWeight = 18, Name = "Four", Type = "Standaard" });
pallets.Add(new Pallet() { ID = 5, TareWeight = 25, Name = "Five", Type = "Double" });
pallets.Add(new Pallet() { ID = 6, TareWeight = 30, Name = "Six", Type = "Double" });
pallets.Add(new Pallet() { ID = 7, TareWeight = 25, Name = "seven", Type = "Half" });
#endregion

//    ○ selecteer alle producten met hun gewicht, het doos gewicht en het pallet gewicht
//var allProducts = from pallet in pallets
//                  join box in boxes on pallet.ID equals box.PalletID
//                  join product in products on box.ID equals product.BoxID
var allProducts = from product in products
                  join box in boxes on product.BoxID equals box.ID
                  join pallet in pallets on box.PalletID equals pallet.ID
                  select $"{product.ID}: {product.Weight} is in box {box.ID}: {box.TareWeight}{}"


//var allproducts2 = products.Join(pallets, x => x.)

//    ○ selecteer alle producten die op een pallet staan van het type 'standaard'
//    ○ Bereken het totale gewicht per doos (Box)



