using berek2020.src;

List<Dolgozo> dolgozok = new();
StreamReader reader = new(@"../../../src/berek2020.txt");
_= reader.ReadLine();
while (!reader.EndOfStream)
{
    dolgozok.Add(new Dolgozo(reader.ReadLine()));
}

Console.WriteLine("3. Feladat:");
Console.WriteLine("\t" + dolgozok.Count);

Console.WriteLine("4. Feladat:");
Console.WriteLine($"\t{ dolgozok.Average(d => d.Fizetes) / 1000:0.0}");

Console.WriteLine("5. Feladat:");
Console.Write("\tAdja meg egy részlegnek a nevét:");
string keresettReszleg = Console.ReadLine();

Console.WriteLine("6. Feladat:");
var legnagyobbFizetes = dolgozok.Where(d => d.Reszleg == keresettReszleg).OrderByDescending(d => d.Fizetes).FirstOrDefault();
Console.WriteLine("\t" + legnagyobbFizetes);

Console.WriteLine("7. Feladat:");
var reszlegStatisztika = dolgozok.GroupBy(d => d.Reszleg);
foreach (var dolgozo in reszlegStatisztika)
{
    Console.WriteLine($"\t{dolgozo.Key}, {dolgozo.Count()}");
}

//Munkaidő: 00:25:10