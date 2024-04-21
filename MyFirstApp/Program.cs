// See on el commento


//Rakendus küsib kasutajal sisestada tema nime
//Tervitab kasutajat nimepidi

Console.WriteLine("Sisestagem nimi:");
//String on sõne (reaalne sõna)
string userName;
userName = Console.ReadLine();
Console.WriteLine("Tervist ja jõudu, " + userName);

//String interpolation
Console.WriteLine($"No Tervist noh, {userName}!");
