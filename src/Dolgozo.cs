namespace berek2020.src
{
    internal class Dolgozo
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Fizetes { get; set; }

        public Dolgozo(string sor)
        {
            var adat = sor.Split(';');
            Nev = adat[0];
            Nem = adat[1] == "férfi";
            Reszleg = adat[2];
            Belepes = int.Parse(adat[3]);
            Fizetes = int.Parse(adat[4]);
        }

        public override string ToString()
        {
            return $"{Nev} ({(Nem ? "férfi" : "nő")}) {Reszleg} {Belepes} {Fizetes}Ft";
        }
    }
}
