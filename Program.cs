using System;

namespace _17._08._2021
{
   class Aktrisa
    {
        public string name;
        public int born;
        public string country;
        public string language;
        public string Citizenship;
        public string Parents;
        public int Children;

        public void GetInfo()
        {
            Console.WriteLine($"Imya aktrisi: {name}");
            Console.WriteLine($"God rozhdeniya: {born}");
            Console.WriteLine($"strana: {country}");
            Console.WriteLine($"yazik: {language}");
            Console.WriteLine($"Grazhdanstvo: {Citizenship}");
            Console.WriteLine($"Roditeli: {Parents}");
            Console.WriteLine($"Deti: {Children}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Aktrisa aktrisa = new Aktrisa();
            aktrisa.name = "Angelina Jolie";
            aktrisa.born = 1975;
            aktrisa.country = "United States";
            aktrisa.language = "English";
            aktrisa.Citizenship = "United States, Cambodia";
            aktrisa.Parents = "Jon Voight, Marcheline Bertrand";
            aktrisa.Children = 6;
            aktrisa.GetInfo();


        }
    }
}
