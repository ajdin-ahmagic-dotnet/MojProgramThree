using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKoda
{
    public class Komentari
    {
        // Već smo se susreli sa komenratima, naime ovaj tekst koji stalno pišem kao pojašnjenja su komentari. 
        // Njih koristimo kako bi nam bilo lakše identificirati šta koji dio koda radi, bez da debagiramo program
        // svaki put, npr. kad dobijemo projekt od kolege progamera, ako nema u kodu komentara puno je teže vidjeti o čemu se zapravo radi. 
        // Dok ako je kod dobro komentarisan čitljiv je svima i lako razumljiv između programera.
        // Komentari se ne izvode kao izvršni kod u C#-pu.
        // Ali recimo možemo ovaj text staviti u jednu string varijablu i ispisati ga na konzolu:                                            

        public static void MainMetoda()
        {
            string komentari =
            @"Već smo se susreli sa komenratima, naime ovaj tekst koji stalno pišem kao pojašnjenja su komentari. 
          Njih koristimo kako bi nam bilo lakše identificirati šta koji dio koda radi, bez da debagiramo program
          svaki put, npr. kad dobijemo projekt od kolege progamera, ako nema u kodu komentara puno je teže vidjeti 
          o čemu se zapravo radi. Dok ako je kod dobro komentarisan čitljiv je svima i lako razumljiv između programera.
          Komentari se ne izvode kao izvršni kod u C#-pu. Ali recimo možemo ovaj text staviti u jednu string varijablu i 
          ispisati ga na konzolu. ";

            Console.WriteLine("Komentar: {0}", komentari);

            var student = new List<Student>()
            {
                new Student {Ime = "Adjin Ahmagić", Starost = 30, Diplomski = "C# Programiranje"},
                new Student {Ime = "Erol Kabaklić", Starost = 22, Diplomski = "PHP Programiranje"},
            };

                var query = from a in student
                            orderby a.Starost
                            select a;

            foreach(var item in query)
            {
            	Console.WriteLine("{0}, {1}, {2}", item.Ime, item.Starost, item.Diplomski);
            }

            List<string> str = new List<string>();

            str.Add("Ajdin");
            str.Add("Ejdin");
            str.Add("Ojdin");
            str.Add("Ijdin");
            str.Add("Ujdin");

            foreach(var item in str)
            {
                Console.WriteLine(item);
            }

        }
    }

    class Student
    {
        public string Ime { get; set; }
        public int Starost { get; set; }
        public string Diplomski { get; set; }
    }
}                 