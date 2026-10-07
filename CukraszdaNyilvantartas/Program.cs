using CukraszdaNyilvantartas;

List<sutemeny> suti = new List<sutemeny>();

for (int i = 0; i < 4; i++)
{

    sutemeny aktualis = new sutemeny();
    Console.WriteLine($"{i + 1} Sutemeny adati");
    Console.Write($"név: ");
    aktualis.Nev = Console.ReadLine();
    Console.Write("egységar: ");
    aktualis.egysegar = int.Parse(Console.ReadLine());
    Console.Write("raktarondb: ");
    aktualis.Raktaron = int.Parse(Console.ReadLine());
    Console.WriteLine();

    suti.Add( aktualis );
}


int listdb = suti.Count;
Console.WriteLine("Pultban levo sutemenyek");
int teljes = 0;
double arak = 0;
for (int i = 0; i < listdb; i++)
{
    int osszeg = 0;
    osszeg = suti[i].egysegar* suti[i].Raktaron;
    Console.WriteLine($"{suti[i].Nev}: {suti[i].egysegar} Ft /{suti[i].Raktaron} db -> Összérték:{osszeg} ft");
    teljes += osszeg;
    arak += suti[i].egysegar;
}

Console.WriteLine($"\nPult teljes készletértéke {teljes} ");
double atlag = arak / listdb;

Console.WriteLine($"Sutemények átlagos egységára {atlag} ");
