internal class Osoba
    {
        string nazwisko;
        string wiek;
        double placa;

        //sposób 1
        public void setNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public string getNazwisko()
        {
            return nazwisko;
        }+
        //sposób 2
        public double Placa
        {
            get { return placa; }
            set { if (value < 3200) placa = 3200; else placa = value; }
        }
        //sposób 3
        public string Imie
        {
            get; set;
        }
    }
}