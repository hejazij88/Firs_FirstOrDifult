List<string> listName = new();

//Throw Exception If Not Found
 Console.WriteLine(listName.First());

//If Don't Find Return Null

Console.WriteLine(listName.FirstOrDefault());


listName.Add("Name1");
listName.Add("Name2");
listName.Add("Name3");
listName.Add("Name4");
listName.Add("Name5");

Console.WriteLine(listName.First(s =>s=="Name1" ));

