using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace MojProgram_Three
{
    internal class Program
    {
        private static string odgovor;
        private static int nastavitiMenuGlobal = 0;
        private static string nastavitiProgram;
        private static int counter = 0;

        static void Main()
        {
            double upit = 0;
            double podUpit = 0;
            double podPodUpit = 0;
            //bool validInput = false;


            #region Upit Za Lozinku

            Console.Title = ".NET 4.5 & C# Programiranje 2";
            Console.WindowHeight = 12;
            Write(
                "╔════════════════════════════════════════╦═════════════════════════════════════════════════╦═════════════════════════════════════════╗"
            );
            Write(
                "║                                        ║--- DOBRODOŠLI U .NET 4.5 C# PROGRAMIRANJE 2 --- ║                                         ║"
            );
            Write(
                "║                                        ║            --- GLAVNI IZBORNIK ---              ║                                         ║"
            );
            Write(
                "║                                        ╚═════════════════════════════════════════════════╝                                         ║"
            );
            Write(
                "║                                         ╔═══════════════════════════════════════════════╗                                          ║"
            );
            Write(
                "║                                         ║           Upišite korisničko ime:             ║                                          ║"
            );
            Write(
                "║                                         ╚═══════════════════════════════════════════════╝                                          ║"
            );
            Write(
                "║                                         ╔═══════════════════════════════════════════════╗                                          ║"
            );
            Write(
                "║                                         ║           Upišite svoju password:             ║                                          ║"
            );
            Write(
                "║                                         ╚═══════════════════════════════════════════════╝                                          ║"
            );
            Write(
                "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
            );
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 12;
            Console.SetBufferSize(134, 12);
            Console.ResetColor();
            #region Čitanje Imena i Lozinke sa Konzole, te postavljanje Kurosra
            // Postavljanje Kursora na poziciju:
            Console.SetCursorPosition(77, 5);
            // Varijabla za Korisnično ime:
            string ime = Console.ReadLine();
            string lozinka = String.Empty;
            // Postavljanje Kursora na poziciju:
            Console.SetCursorPosition(77, 8);
            // Varijabla za Lozinku:
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace ne bi smjeo da radi!
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    lozinka += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && lozinka.Length > 0)
                    {
                        lozinka = lozinka.Substring(0, (lozinka.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Prekida Dobivati Key kada je Enter pritisnut!
            while (key.Key != ConsoleKey.Enter);

            #endregion

            #endregion// Upit za Lozinku

            while (counter < 10)
            {
                #region KONEKCIJA NA BAZU-PROGRAM-PODPROGAM // Jako bitno je preficirati bazin table sa "dbo.Login"

                // Postavljanje Konekcije na SQL bazu //
                using (
                    var conn = new SqlConnection(
                        @"Data Source=.\SQLSERVER;Initial Catalog=LoginDB;Integrated Security=True"
                    )
                )
                {
                    conn.Open();
                    // Čitanje korisničnog imena i lozinke iz baze... //
                    var sda = new SqlDataAdapter(
                        String.Format(
                            "SELECT Count(*) FROM dbo.Users WHERE Ime='{0}' AND Lozinka='{1}'",
                            ime,
                            lozinka
                        ),
                        conn
                    );
                    // Punjenje Table sa podatcima //
                    var dt = new DataTable();
                    sda.Fill(dt);

                    #region DATA I GLAVNI PROGAM IF

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        #region CIJELI PROGRAM
                        #region GLAVNI MENI
                        Console.Clear();
                        Console.WindowHeight = 22;
                        Console.Title = "C# PROGRAMIRANJE";
                        Write(
                            "╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗"
                        );
                        Write(
                            "║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║"
                        );
                        Write(
                            "║                         ║                     --- DOBRODOŠLI U: C# Programiranje 2 ---                   ║                         ║"
                        );
                        Write(
                            "║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║"
                        );
                        Write(
                            "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                        );
                        Write(
                            "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                        );
                        Write(
                            "║                                          ║           --- GLAVNI IZBORNIK ---             ║                                         ║"
                        );
                        Write(
                            "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                        );
                        Write(
                            "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                        );
                        Write(
                            "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                        );
                        Write(
                            "║                                          ║         [1. C# Fundamentalne Osnove 1]        ║                                         ║"
                        );
                        Write(
                            "║                                          ║         [1. C# Fundamentalne Osnove 2]        ║                                         ║"
                        );
                        Write(
                            "║                                          ║         [1. C# Objektno-Orijentirano ]        ║                                         ║"
                        );
                        Write(
                            "║                                          ╠═══════════════════════════════════════════════╣                                         ║"
                        );
                        Write(
                            "║                                          ║                   [2. Izlaz]                  ║                                         ║"
                        );
                        Write(
                            "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                        );
                        Write(
                            "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                        );
                        Write(
                            "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                        );
                        Write(
                            "║                                          ║            UNESITE BROJ PROGRAMA:             ║                                         ║"
                        );
                        Write(
                            "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                        );
                        Write(
                            "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
                        );
                        Console.SetCursorPosition(78, 18);
                        Console.SetBufferSize(134, 22);
                        bool ok;
                        TryParseMetoda_1(out upit, out ok);

                        #endregion// GLAVNI MENI

                        #region GLAVNI IF

                        if (!ok || upit > 2)
                        {
                            Console.Clear();
                            Console.WindowHeight = 10;
                            Console.BufferHeight = 10;
                            Write(
                                "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                            );
                            Write(
                                "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                            );
                            Write(
                                "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite 'DA'!!!       ║                              ║"
                            );
                            Write(
                                "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                            );
                            Write(
                                "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                            );
                            Write(
                                "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                            );
                            Write(
                                "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                            );
                            Write(
                                "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                            );
                            Write(
                                "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                            );
                            Console.SetCursorPosition(83, 6);
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            odgovor = Console.ReadLine();

                            if (
                                odgovor != null
                                && odgovor.ToLowerInvariant() == "DA".ToLowerInvariant()
                            )
                            {
                                nastavitiMenuGlobal = 0;
                            }
                            else
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WindowHeight = 10;
                                    Console.BufferHeight = 10;
                                    Write(
                                        "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                    );
                                    Write(
                                        "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                                    );
                                    Write(
                                        "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                                    );
                                    Write(
                                        "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                                    );
                                    Write(
                                        "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                                    );
                                    Write(
                                        "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                                    );
                                    Write(
                                        "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                                    );
                                    Write(
                                        "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                                    );
                                    Write(
                                        "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                    );
                                    Console.SetCursorPosition(83, 6);
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    odgovor = Console.ReadLine();
                                } while (odgovor == String.Empty);
                                nastavitiMenuGlobal = 0;
                            }
                            if (
                                odgovor != null
                                && odgovor.ToLowerInvariant() == "NE".ToLowerInvariant()
                            )
                            {
                                counter = 15;
                                Console.Clear();
                                Console.WindowHeight = 6;
                                Console.BufferHeight = 6;
                                Write(
                                    "╔══════════════════════════╦═══════════════════════════════════════════════════════════════════════════════╦═════════════════════════╗"
                                );
                                Write(
                                    "║                          ║ ╔═══════════════════════════════════════════════════════════════════════════╗ ║                         ║"
                                );
                                Write(
                                    "║                          ║ ║ODABRALI STE POTPUNI IZLAZ IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA IZLAZ.║ ║                         ║"
                                );
                                Write(
                                    "║                          ║ ╚═══════════════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©           ║"
                                );
                                Write(
                                    "╚══════════════════════════╩═══════════════════════════════════════════════════════════════════════════════╩═════════════════════════╝"
                                );
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ReadKey();
                            }
                        }
                        #endregion// GLAVNI IF

                        #region GLAVNI ELSE

                        else
                        {
                            #region IF
                            if (upit == 1)
                            {
                                do
                                {
                                    #region  POD GLAVNI MENI
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.WindowHeight = 29;
                                    Write(
                                        "╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗"
                                    );
                                    Write(
                                        "║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║"
                                    );
                                    Write(
                                        "║                         ║                --- DOBRODOŠLI U:  C# Fundamentalne Osnove 1 ---                ║                         ║"
                                    );
                                    Write(
                                        "║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║"
                                    );
                                    Write(
                                        "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                    );
                                    Write(
                                        "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                                    );
                                    Write(
                                        "║                                          ║           --- GLAVNI IZBORNIK ---             ║                                         ║"
                                    );
                                    Write(
                                        "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                                    );
                                    Write(
                                        "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                    );
                                    Write(
                                        "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                                    );
                                    Write(
                                        "║                                          ║ 1. Program: [Varijable, Tipovi, Ptelje...]    ║                                         ║"
                                    );
                                    Write(
                                        "║                                          ╠═══════════════════════════════════════════════╣                                         ║"
                                    );
                                    Write(
                                        "║                                          ║ 4. Izlaz Iz Programa                          ║                                         ║"
                                    );
                                    Write(
                                        "║                                          ║ 5. Izlaz Iz Konzole                           ║                                         ║"
                                    );
                                    Write(
                                        "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                                    );
                                    Write(
                                        "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                    );
                                    Write(
                                        "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                                    );
                                    Write(
                                        "║                                          ║            UNESITE BROJ PROGRAMA:             ║                                         ║"
                                    );
                                    Write(
                                        "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                                    );
                                    Write(
                                        "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
                                    );
                                    Console.SetCursorPosition(78, 25);
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WindowHeight = 29;
                                    Console.SetBufferSize(134, 29);

                                    bool ok2;
                                    TryParseMetoda_2(out podUpit, out ok2);
                                    #endregion//GLAVNI MENI

                                    #region POD IF

                                    if (!ok2 || podUpit > 11)
                                    {
                                        Console.Clear();
                                        Console.WindowHeight = 10;
                                        Console.BufferHeight = 10;
                                        Write(
                                            "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                        );
                                        Write(
                                            "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                                        );
                                        Write(
                                            "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite 'DA'!!!       ║                              ║"
                                        );
                                        Write(
                                            "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                                        );
                                        Write(
                                            "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                                        );
                                        Write(
                                            "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                                        );
                                        Write(
                                            "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                                        );
                                        Write(
                                            "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                                        );
                                        Write(
                                            "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                        );
                                        Console.SetCursorPosition(83, 6);
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        odgovor = Console.ReadLine();

                                        if (
                                            odgovor != null
                                            && odgovor.ToLowerInvariant() == "DA".ToLowerInvariant()
                                        )
                                        {
                                            nastavitiMenuGlobal = 1;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                Console.Clear();
                                                Console.WindowHeight = 10;
                                                Console.BufferHeight = 10;
                                                Write(
                                                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                                );
                                                Write(
                                                    "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                                                );
                                                Write(
                                                    "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                                                );
                                                Write(
                                                    "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                                                );
                                                Write(
                                                    "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                                                );
                                                Write(
                                                    "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                                                );
                                                Write(
                                                    "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                                                );
                                                Write(
                                                    "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                                                );
                                                Write(
                                                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                                );
                                                Console.SetCursorPosition(83, 6);
                                                Console.BackgroundColor = ConsoleColor.Yellow;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                odgovor = Console.ReadLine();
                                            } while (odgovor == String.Empty);
                                            nastavitiMenuGlobal = 1;
                                        }
                                        if (
                                            odgovor != null
                                            && odgovor.ToLowerInvariant() == "NE".ToLowerInvariant()
                                        )
                                        {
                                            counter = 15;
                                            Console.Clear();
                                            Console.WindowHeight = 6;
                                            Console.BufferHeight = 6;
                                            Write(
                                                "╔══════════════════════════╦═══════════════════════════════════════════════════════════════════════════════╦═════════════════════════╗"
                                            );
                                            Write(
                                                "║                          ║ ╔═══════════════════════════════════════════════════════════════════════════╗ ║                         ║"
                                            );
                                            Write(
                                                "║                          ║ ║ODABRALI STE POTPUNI IZLAZ IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA IZLAZ.║ ║                         ║"
                                            );
                                            Write(
                                                "║                          ║ ╚═══════════════════════════════════════════════════════════════════════════╝ ║                         ║"
                                            );
                                            Write(
                                                "╚══════════════════════════╩═══════════════════════════════════════════════════════════════════════════════╩═════════════════════════╝"
                                            );
                                            Console.BackgroundColor = ConsoleColor.Yellow;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.ReadKey();
                                        }

                                        //// Ako odgovor nije niti broj niti slovo nego prazan string, ostani unutar menuija programa! //
                                        //if (odgovor == String.Empty)
                                        //{
                                        //    nastavitiMenuGlobal = 1;
                                        //}
                                        //Console.ResetColor();
                                    }
                                    #endregion// POD IF

                                    #region POD ELSE
                                    else
                                    {
                                        #region POD IF 1
                                        // IF PROGRAM SE SASTOJI OD DO-WHILE PETLJE, IF IZRAZA, TE TIJEL APROGRAMA KOJI SE ILI IZVODI LOKALNO ILI KORISTI VANJSKI ASSEMBLY //
                                        if (podUpit == 1)
                                        {
                                            do
                                            {
                                                #region POD-POD GLAVNI MENI
                                                Console.Clear();
                                                Console.BackgroundColor = ConsoleColor.Yellow;
                                                Console.WindowHeight = 27;
                                                Write(
                                                    "╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗"
                                                );
                                                Write(
                                                    "║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║"
                                                );
                                                Write(
                                                    "║                         ║                  --- DOBRODOŠLI U: Fundamentalne Osnove 1 ---                  ║                         ║"
                                                );
                                                Write(
                                                    "║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║"
                                                );
                                                Write(
                                                    "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                                );
                                                Write(
                                                    "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║           --- GLAVNI IZBORNIK ---             ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                                                );
                                                Write(
                                                    "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                                );
                                                Write(
                                                    "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 1. Program: [Varijable]                       ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 2. Program: [Tipovi Podataka]                 ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 3. Program: [Arrays]                          ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 4. Program: [If-Else]                         ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 5. Program: [Switch]                          ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 6. Program: [Do-while]                        ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 7. Program: [While]                           ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 8. Program: [For]                             ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║ 9. Program: [Foreach]                         ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ╠═══════════════════════════════════════════════╣                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║10. Izlaz Na Program Kompilacija               ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║11. Izlaz Na Glavni Meni                       ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║12. Izlaz Iz Konzole                           ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                                                );
                                                Write(
                                                    "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                                );
                                                Write(
                                                    "║                                          ╔═══════════════════════════════════════════════╗                                         ║"
                                                );
                                                Write(
                                                    "║                                          ║            UNESITE BROJ PROGRAMA:             ║                                         ║"
                                                );
                                                Write(
                                                    "║                                          ╚═══════════════════════════════════════════════╝                                         ║"
                                                );
                                                Write(
                                                    "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
                                                );
                                                Console.SetCursorPosition(78, 23);
                                                Console.WindowHeight = 27;
                                                Console.SetBufferSize(134, 27);

                                                bool ok3;
                                                TryParseMetoda_3(out podPodUpit, out ok3);

                                                #endregion// MENI

                                                #region POD-POD IF
                                                if (!ok3 || podPodUpit > 9)
                                                {
                                                    Console.Clear();
                                                    Console.WindowHeight = 10;
                                                    Console.BufferHeight = 10;
                                                    Write(
                                                        "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                                    );
                                                    Write(
                                                        "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                                                    );
                                                    Write(
                                                        "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite 'DA'!!!       ║                              ║"
                                                    );
                                                    Write(
                                                        "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                                                    );
                                                    Write(
                                                        "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                                                    );
                                                    Write(
                                                        "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                                                    );
                                                    Write(
                                                        "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                                                    );
                                                    Write(
                                                        "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                                                    );
                                                    Write(
                                                        "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                                    );
                                                    Console.SetCursorPosition(83, 6);
                                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                                    Console.ForegroundColor = ConsoleColor.Black;
                                                    odgovor = Console.ReadLine();

                                                    if (
                                                        odgovor != null
                                                        && odgovor == "DA".ToLowerInvariant()
                                                    )
                                                    {
                                                        nastavitiMenuGlobal = 2;
                                                    }
                                                    else
                                                    {
                                                        do
                                                        {
                                                            Console.Clear();
                                                            Console.WindowHeight = 10;
                                                            Console.BufferHeight = 10;
                                                            Write(
                                                                "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                                            );
                                                            Write(
                                                                "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                                                            );
                                                            Write(
                                                                "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                                                            );
                                                            Write(
                                                                "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                                                            );
                                                            Write(
                                                                "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                                                            );
                                                            Write(
                                                                "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                                                            );
                                                            Write(
                                                                "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                                                            );
                                                            Write(
                                                                "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                                                            );
                                                            Write(
                                                                "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                                            );
                                                            Console.SetCursorPosition(83, 6);
                                                            Console.BackgroundColor =
                                                                ConsoleColor.Yellow;
                                                            Console.ForegroundColor =
                                                                ConsoleColor.Black;
                                                            odgovor = Console.ReadLine();
                                                        } while (odgovor == String.Empty);
                                                        nastavitiMenuGlobal = 2;
                                                    }
                                                    if (
                                                        odgovor != null
                                                        && odgovor.ToLowerInvariant()
                                                            == "NE".ToLowerInvariant()
                                                    )
                                                    {
                                                        counter = 15;
                                                        Console.Clear();
                                                        Console.WindowHeight = 6;
                                                        Console.BufferHeight = 6;
                                                        Write(
                                                            "╔══════════════════════════╦═══════════════════════════════════════════════════════════════════════════════╦═════════════════════════╗"
                                                        );
                                                        Write(
                                                            "║                          ║ ╔═══════════════════════════════════════════════════════════════════════════╗ ║                         ║"
                                                        );
                                                        Write(
                                                            "║                          ║ ║ODABRALI STE POTPUNI IZLAZ IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA IZLAZ.║ ║                         ║"
                                                        );
                                                        Write(
                                                            "║                          ║ ╚═══════════════════════════════════════════════════════════════════════════╝ ║                         ║"
                                                        );
                                                        Write(
                                                            "╚══════════════════════════╩═══════════════════════════════════════════════════════════════════════════════╩═════════════════════════╝"
                                                        );
                                                        Console.BackgroundColor =
                                                            ConsoleColor.Yellow;
                                                        Console.ForegroundColor =
                                                            ConsoleColor.Black;
                                                        Console.ReadKey();
                                                    }

                                                    //if (odgovor == String.Empty)
                                                    //{
                                                    //    nastavitiMenuGlobal = 2;
                                                    //}
                                                    //Console.ResetColor();
                                                }
                                                #endregion

                                                #region ELSE Reagion (ovdje su Programi)
                                                else
                                                {
                                                    #region Varijable Program
                                                    // IF PROGRAM SE SASTOJI OD DO-WHILE PETLJE, IF IZRAZA, TE TIJEL APROGRAMA KOJI SE ILI IZVODI LOKALNO ILI KORISTI VANJSKI ASSEMBLY //
                                                    if (podPodUpit == 1)
                                                    {
                                                        Console.Clear();

                                                        // IF-ska do-while Petlja:
                                                        do
                                                        {
                                                            KadSeVratisPokreniProgramIspocetka:
                                                            Console.WindowHeight = 25;
                                                            Write(
                                                                "╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗"
                                                            );
                                                            Write(
                                                                "║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║"
                                                            );
                                                            Write(
                                                                "║                         ║                    --- DOBRODOŠLI U: MOJ PRVI C# PROGRAM ---                   ║                         ║"
                                                            );
                                                            Write(
                                                                "║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║"
                                                            );
                                                            Write(
                                                                "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                                            );
                                                            Write(
                                                                "║                                                                                                                                    ║"
                                                            );
                                                            Write(
                                                                "║ Da li želite da Pokrente Program DA/NE:                                                                                            ║"
                                                            );
                                                            Write(
                                                                "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
                                                            );
                                                            Console.SetCursorPosition(41, 6);
                                                            Console.BackgroundColor =
                                                                ConsoleColor.Yellow;
                                                            Console.ForegroundColor =
                                                                ConsoleColor.Black;

                                                            var odgovor = Console.ReadLine();
                                                            if (odgovor == "DA".ToLowerInvariant())
                                                            {
                                                                ///////////////////////////////////////////////////////////////////////////////////////////////////
                                                                /////////////////////////////////--------IZVOĐENJE PROGRAMA------//////////////////////////////////
                                                                Console.WriteLine();
                                                                Console.WriteLine();

                                                                ///////////////////////////////////////////////////////////////////////////////////////////////////
                                                                ///////////////////////////////////////////////////////////////////////////////////////////////////
                                                            }
                                                            if (odgovor == "NE".ToLowerInvariant())
                                                            {
                                                                if (NastavitiProgramMetoda())
                                                                    break;
                                                                Console.Clear();
                                                                goto KadSeVratisPokreniProgramIspocetka;
                                                            }

                                                            Console.WriteLine();
                                                            Console.WriteLine();
                                                            Console.Write(
                                                                "Da li želite da nastavite sa Programom? DA/NE: "
                                                            );

                                                            nastavitiProgram = Console.ReadLine();
                                                            Console.Clear();

                                                            if (
                                                                nastavitiProgram
                                                                == "NE".ToLowerInvariant()
                                                            )
                                                            {
                                                                if (NastavitiProgramMetoda())
                                                                    break;
                                                                Console.Clear();
                                                            }

                                                            // Metoda koja riješava prazan string i nepravile karaktere //

                                                            NastavitiProgramEmptyIGreska();
                                                            Console.Clear();
                                                        } while (
                                                            nastavitiProgram == "Da"
                                                            || nastavitiProgram == "DA"
                                                            || nastavitiProgram == "da"
                                                        );
                                                    }

                                                    #endregion// IF 2 IZLAZ



                                                    #region IZLAZNI IF - ovi
                                                    if (podPodUpit == 10)
                                                    {
                                                        nastavitiMenuGlobal = 1;
                                                        Console.Clear();
                                                        Console.WindowHeight = 6;
                                                        Console.BufferHeight = 6;
                                                        Write(
                                                            "╔═════════════════════╦═════════════════════════════════════════════════════════════════════════════════════╦════════════════════════╗"
                                                        );
                                                        Write(
                                                            "║                     ║ ╔═════════════════════════════════════════════════════════════════════════════════╗ ║                        ║"
                                                        );
                                                        Write(
                                                            "║                     ║ ║UPRAVO STE IZAŠLI IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA POVRATAK NA IZBORNIK.║ ║                        ║"
                                                        );
                                                        Write(
                                                            "║                     ║ ╚═════════════════════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©          ║"
                                                        );
                                                        Write(
                                                            "╚═════════════════════╩═════════════════════════════════════════════════════════════════════════════════════╩════════════════════════╝"
                                                        );
                                                        Console.BackgroundColor =
                                                            ConsoleColor.Yellow;
                                                        Console.ForegroundColor =
                                                            ConsoleColor.Black;
                                                        break;
                                                    }
                                                    if (podPodUpit == 11)
                                                    {
                                                        nastavitiMenuGlobal = 2;
                                                        Console.Clear();
                                                        Console.WindowHeight = 6;
                                                        Console.BufferHeight = 6;
                                                        Write(
                                                            "╔═════════════════════╦═════════════════════════════════════════════════════════════════════════════════════╦════════════════════════╗"
                                                        );
                                                        Write(
                                                            "║                     ║ ╔═════════════════════════════════════════════════════════════════════════════════╗ ║                        ║"
                                                        );
                                                        Write(
                                                            "║                     ║ ║UPRAVO STE IZAŠLI IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA POVRATAK NA IZBORNIK.║ ║                        ║"
                                                        );
                                                        Write(
                                                            "║                     ║ ╚═════════════════════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©          ║"
                                                        );
                                                        Write(
                                                            "╚═════════════════════╩═════════════════════════════════════════════════════════════════════════════════════╩════════════════════════╝"
                                                        );
                                                        Console.BackgroundColor =
                                                            ConsoleColor.Yellow;
                                                        Console.ForegroundColor =
                                                            ConsoleColor.Black;
                                                        break;
                                                    }
                                                    if (podPodUpit == 12)
                                                    {
                                                        counter = 15;
                                                        Console.Clear();
                                                        Console.WindowHeight = 6;
                                                        Console.BufferHeight = 6;
                                                        Write(
                                                            "╔══════════════════════════╦═══════════════════════════════════════════════════════════════════════════════╦═════════════════════════╗"
                                                        );
                                                        Write(
                                                            "║                          ║ ╔═══════════════════════════════════════════════════════════════════════════╗ ║                         ║"
                                                        );
                                                        Write(
                                                            "║                          ║ ║ODABRALI STE POTPUNI IZLAZ IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA IZLAZ.║ ║                         ║"
                                                        );
                                                        Write(
                                                            "║                          ║ ╚═══════════════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©           ║"
                                                        );
                                                        Write(
                                                            "╚══════════════════════════╩═══════════════════════════════════════════════════════════════════════════════╩═════════════════════════╝"
                                                        );
                                                        Console.BackgroundColor =
                                                            ConsoleColor.Yellow;
                                                        Console.ForegroundColor =
                                                            ConsoleColor.Black;
                                                        Console.ReadKey();
                                                    }
                                                    #endregion// Izlani IF - ovi
                                                }
                                                #endregion
                                            } while (counter < 10 && nastavitiMenuGlobal == 2); // S obzirom da sada imamo 3, a možda i više ugnježđenih podprograma globalNastavitiMenu je sada inicijaliziran na 2. //
                                        }
                                        #endregion// IF 2 IZLAZ
                                        #region POD IF 2
                                        if (podUpit == 2)
                                        {
                                            // Čeka implementaciju... //
                                            #region Primjer porcesa
                                            //try
                                            //{

                                            //    using(Process firstProc = new Process())
                                            //    {
                                            //        firstProc.StartInfo.FileName = "notepad.exe";
                                            //        firstProc.EnableRaisingEvents = true;

                                            //        firstProc.Start();

                                            //        firstProc.WaitForExit();

                                            //        //You may want to perform different actions depending on the exit code.
                                            //        Console.WriteLine("First process exited: " + firstProc.ExitCode);
                                            //    }

                                            //    using(Process secondProc = new Process())
                                            //    {
                                            //        secondProc.StartInfo.FileName = "mspaint.exe";
                                            //        secondProc.Start();
                                            //    }

                                            //}
                                            //catch(Exception ex)
                                            //{
                                            //    Console.WriteLine("An error occurred!!!: " + ex.Message);
                                            //    return;
                                            //}
                                            #endregion
                                        }
                                        #endregion// IF 2 IZLAZ
                                        #region POD IF 3
                                        if (podUpit == 3)
                                        {
                                            Console.Clear();
                                            do
                                            {
                                                KadSeVratisPokreniProgramIspocetka:
                                                Console.WindowHeight = 25;
                                                Write(
                                                    "╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗"
                                                );
                                                Write(
                                                    "║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║"
                                                );
                                                Write(
                                                    "║                         ║                    --- DOBRODOŠLI U: KOMENTARI PRIMJER 1 ---                   ║                         ║"
                                                );
                                                Write(
                                                    "║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║"
                                                );
                                                Write(
                                                    "╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣"
                                                );
                                                Write(
                                                    "║                                                                                                                                    ║"
                                                );
                                                Write(
                                                    "║ Da li želite da Pokrente Program DA/NE:                                                                                            ║"
                                                );
                                                Write(
                                                    "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
                                                );
                                                Console.SetCursorPosition(41, 6);
                                                Console.BackgroundColor = ConsoleColor.Yellow;
                                                Console.ForegroundColor = ConsoleColor.Black;

                                                var odgovor = Console.ReadLine();
                                                if (odgovor == "DA".ToLowerInvariant())
                                                {
                                                    ///////////////////////////////////////////////////////////////////////////////////////////////
                                                    /////////////////////////////////////// IZVOĐENJE PROGRAMA ////////////////////////////////////
                                                    // Poziv Programu:
                                                    Console.WriteLine();
                                                    Console.WriteLine();

                                                    ///////////////////////////////////////////////////////////////////////////////////////////////
                                                    ///////////////////////////////////////////////////////////////////////////////////////////////
                                                }
                                                else if (odgovor == "NE".ToLowerInvariant())
                                                {
                                                    if (NastavitiProgramMetoda())
                                                        break;
                                                    Console.ReadLine();
                                                    goto KadSeVratisPokreniProgramIspocetka;
                                                }

                                                ///////////////////////////////////////////////////////
                                                ///////////////////////////////////////////////////////
                                                // Završni Dio Programa:
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.Write(
                                                    "Da li želite nastiti sa Programom DA/NE:"
                                                );

                                                nastavitiProgram = Console.ReadLine();

                                                // Jako je bitno očistiti konzolu ovdje od prijašnjeg teksta, jer ako se ne očisti
                                                // napisat će duplo zaglavlje! //
                                                Console.Clear();

                                                if (nastavitiProgram == "NE".ToLowerInvariant())
                                                {
                                                    if (NastavitiProgramMetoda())
                                                        break;
                                                    Console.Clear();
                                                }

                                                NastavitiProgramEmptyIGreska();
                                                Console.Clear();
                                                ///////////////////////////////////////////////////////
                                                ///////////////////////////////////////////////////////
                                            } while (nastavitiProgram == "DA".ToLowerInvariant());
                                        }
                                        #endregion// IF 2 IZLAZ

                                        #region IZLAZNI IF - ovi
                                        if (podUpit == 4)
                                        {
                                            nastavitiMenuGlobal = 0;
                                            Console.Clear();
                                            Console.WindowHeight = 6;
                                            Console.BufferHeight = 6;
                                            Write(
                                                "╔═════════════════════╦═════════════════════════════════════════════════════════════════════════════════════╦════════════════════════╗"
                                            );
                                            Write(
                                                "║                     ║ ╔═════════════════════════════════════════════════════════════════════════════════╗ ║                        ║"
                                            );
                                            Write(
                                                "║                     ║ ║UPRAVO STE IZAŠLI IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA POVRATAK NA IZBORNIK.║ ║                        ║"
                                            );
                                            Write(
                                                "║                     ║ ╚═════════════════════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©          ║"
                                            );
                                            Write(
                                                "╚═════════════════════╩═════════════════════════════════════════════════════════════════════════════════════╩════════════════════════╝"
                                            );
                                            Console.BackgroundColor = ConsoleColor.Yellow;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            break;
                                        }
                                        if (podUpit == 5)
                                        {
                                            counter = 15;
                                            Console.Clear();
                                            Console.WindowHeight = 6;
                                            Console.BufferHeight = 6;
                                            Write(
                                                "╔══════════════════════════╦═══════════════════════════════════════════════════════════════════════════════╦═════════════════════════╗"
                                            );
                                            Write(
                                                "║                          ║ ╔═══════════════════════════════════════════════════════════════════════════╗ ║                         ║"
                                            );
                                            Write(
                                                "║                          ║ ║ODABRALI STE POTPUNI IZLAZ IZ PROGRAMA.PRITISNITE BILO KOJU TIPKU ZA IZLAZ.║ ║                         ║"
                                            );
                                            Write(
                                                "║                          ║ ╚═══════════════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©           ║"
                                            );
                                            Write(
                                                "╚══════════════════════════╩═══════════════════════════════════════════════════════════════════════════════╩═════════════════════════╝"
                                            );
                                            Console.BackgroundColor = ConsoleColor.Yellow;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.ReadKey();
                                        }
                                        #endregion
                                    }
                                    #endregion// POD ELSE
                                } while (counter < 10 && nastavitiMenuGlobal == 1);
                            }
                            #endregion// IF

                            #region IF 2 - Trenutno Je Izlaz
                            if (upit == 2)
                            {
                                counter = 15;
                                Console.Clear();
                                Console.WindowHeight = 6;
                                Console.BufferHeight = 6;
                                Write(
                                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                );
                                Write(
                                    "║                             ║  ╔══════════════════════════════════════════════════════════════════╗ ║                              ║"
                                );
                                Write(
                                    "║                             ║  ║UPRAVO STE IZAŠLI IZ PROGRAMA.ZA POTPUNO GAŠENJE PRITISNITE ENTER.║ ║                              ║"
                                );
                                Write(
                                    "║                             ║  ╚══════════════════════════════════════════════════════════════════╝ ║                              ║"
                                );
                                Write(
                                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                );
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ReadKey();
                            }
                            #endregion
                        }
                        #endregion// GLAVNI ELSE

                        #endregion//CIJELI PROGRAM
                    }
                    #endregion//DATA I GLAVNI PROGAM IF
                    #region DATA ELSE

                    else
                    {
                        Console.Clear();
                        Console.WindowHeight = 10;
                        Console.BufferHeight = 10;
                        Write(
                            "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                        );
                        Write(
                            "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                        );
                        Write(
                            "║                             ║            !!!Nismo vas uspjeli autentificirati u SQL bazi!!!         ║                              ║"
                        );
                        Write(
                            "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite DA.!!!        ║                              ║"
                        );
                        Write(
                            "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                        );
                        Write(
                            "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                        );
                        Write(
                            "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                        );
                        Write(
                            "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                        );
                        Write(
                            "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                        );
                        Console.SetCursorPosition(83, 6);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        odgovor = Console.ReadLine();

                        if (odgovor == "NE".ToLowerInvariant())
                        {
                            counter = 13;
                            Console.Clear();
                            Console.WindowHeight = 6;
                            Console.BufferHeight = 6;
                            Write(
                                "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                            );
                            Write(
                                "║                             ║  ╔══════════════════════════════════════════════════════════════════╗ ║                              ║"
                            );
                            Write(
                                "║                             ║  ║UPRAVO STE IZAŠLI IZ PROGRAMA.ZA POTPUNO GAŠENJE PRITISNITE ENTER.║ ║                              ║"
                            );
                            Write(
                                "║                             ║  ╚══════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©                ║"
                            );
                            Write(
                                "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                            );
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.ReadKey();
                        }
                        else if (odgovor == String.Empty)
                        {
                            do
                            {
                                Console.Clear();
                                Console.WindowHeight = 10;
                                Console.BufferHeight = 10;
                                Write(
                                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                                );
                                Write(
                                    "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                                );
                                Write(
                                    "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                                );
                                Write(
                                    "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                                );
                                Write(
                                    "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                                );
                                Write(
                                    "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                                );
                                Write(
                                    "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                                );
                                Write(
                                    "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                                );
                                Write(
                                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                                );
                                Console.SetCursorPosition(83, 6);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                odgovor = Console.ReadLine();
                            } while (odgovor == String.Empty);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WindowHeight = 12;
                            Write(
                                "╔═════════════════════════════════════════╦═══════════════════════════════════════════════╦══════════════════════════════════════════╗"
                            );
                            Write(
                                "║                                         ║   --- DOBRODOŠLI U MOJ VISUAL C# PROGRAM ---  ║                                          ║"
                            );
                            Write(
                                "║                                         ║           --- GLAVNI IZBORNIK ---             ║                                          ║"
                            );
                            Write(
                                "║                                         ╚═══════════════════════════════════════════════╝                                          ║"
                            );
                            Write(
                                "║                                         ╔═══════════════════════════════════════════════╗                                          ║"
                            );
                            Write(
                                "║                                         ║           Upišite korisničko ime:             ║                                          ║"
                            );
                            Write(
                                "║                                         ╚═══════════════════════════════════════════════╝                                          ║"
                            );
                            Write(
                                "║                                         ╔═══════════════════════════════════════════════╗                                          ║"
                            );
                            Write(
                                "║                                         ║           Upišite svoju password:             ║                                          ║"
                            );
                            Write(
                                "║                                         ╚═══════════════════════════════════════════════╝                                          ║"
                            );
                            Write(
                                "╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝"
                            );
                            Console.SetCursorPosition(83, 6);
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;

                            // Ime i Lozinka se ne deklarairju ponovno jer koristimo već deklarirane vrijednosti jer moramo.
                            #region Čitanje Imena i Lozinke sa Konzole, te postavljanje Kurosra

                            // Postavljanje Kursora:
                            Console.SetCursorPosition(77, 5);

                            // Postavljanje Ime varijable:
                            ime = Console.ReadLine();

                            // Postavljanje Kursora:
                            Console.SetCursorPosition(77, 8);
                            lozinka = String.Empty;
                            // Postavljanje Lozinka varijable:
                            // lozinka = Console.ReadLine();
                            ConsoleKeyInfo key2;

                            do
                            {
                                key2 = Console.ReadKey(true);

                                // Backspace ne bi smjeo da radi!
                                if (
                                    key2.Key != ConsoleKey.Backspace
                                    && key2.Key != ConsoleKey.Enter
                                )
                                {
                                    lozinka += key2.KeyChar;
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (key2.Key == ConsoleKey.Backspace && lozinka.Length > 0)
                                    {
                                        lozinka = lozinka.Substring(0, (lozinka.Length - 1));
                                        Console.Write("\b \b");
                                    }
                                }
                            }
                            // Prekida Dobivati Key kada je Enter pritisnut!
                            while (key2.Key != ConsoleKey.Enter);
                            #endregion//Čitanje Imena i Lozinke sa Konzole, te postavljanje Kurosra
                        }
                    }
                    #endregion

                    conn.Close();
                }
                #endregion//KONEKCIJA NA BAZU
            }
        }

        #region NastavitiProgramEmptyIGreska Metoda

        private static void NastavitiProgramEmptyIGreska()
        {
            if (nastavitiProgram == String.Empty)
            {
                Console.Clear();
                Console.WindowHeight = 9;
                Console.BufferHeight = 9;
                Write(
                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                );
                Write(
                    "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                );
                Write(
                    "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite DA.!!!        ║                              ║"
                );
                Write(
                    "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                );
                Write(
                    "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                );
                Write(
                    "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                );
                Write(
                    "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                );
                Write(
                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                );
                Console.SetCursorPosition(83, 5);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                odgovor = Console.ReadLine();

                nastavitiProgram = "DA".ToLowerInvariant();
                //Console.Clear();
            }
            else if (nastavitiProgram.Length > 2)
            {
                Console.Clear();
                Console.WindowHeight = 10;
                Console.BufferHeight = 10;
                Write(
                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                );
                Write(
                    "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                );
                Write(
                    "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                );
                Write(
                    "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                );
                Write(
                    "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                );
                Write(
                    "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                );
                Write(
                    "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                );
                Write(
                    "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                );
                Write(
                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                );
                Console.SetCursorPosition(83, 6);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                odgovor = Console.ReadLine();
                nastavitiProgram = "DA".ToLowerInvariant();
            }
        }

        #endregion

        #region TRY-PARSE METODE

        #region TRYPARSE METODA 1 - OK1
        /// <summary>
        /// Extraktirali smo metodu TryParse double
        /// </summary>
        /// <param name="upit"></param>
        /// <param name="ok"></param>
        private static void TryParseMetoda_1(out double upit, out bool ok)
        {
            ok = double.TryParse(Console.ReadLine(), out upit);
        }
        #endregion
        #region TRYPARSE METODA 2 - OK2
        private static void TryParseMetoda_2(out double podUpit, out bool ok2)
        {
            ok2 = double.TryParse(Console.ReadLine(), out podUpit);
        }
        #endregion
        #region TRYPARSE METODA 3 - OK3

        private static void TryParseMetoda_3(out double podPodUpit, out bool ok3)
        {
            // Upit za "Unesite broj programa":
            ok3 = double.TryParse(Console.ReadLine(), out podPodUpit);
        }
        #endregion
        #endregion

        #region NASTAVITI PROGRAM METODA

        internal static bool NastavitiProgramMetoda()
        {
            string odgovor;
            Console.WindowHeight = 7;
            Console.BufferHeight = 7;
            Write(
                "╔══════════╦══════════════════════════════════════════════════════════════════════════════════════════════════════════════╦══════════╗"
            );
            Write(
                "║          ║╔════════════════════════════════════════════════════════════════════════════════════════════════════════════╗║          ║"
            );
            Write(
                "║          ║║UPRAVO STE IZAŠLI IZ PROGRAMA.PRITISNITE (1) ZA PROGRAMSKI MENI, (2) ZA KOMPILACIJA MENI, (3) ZA GLAVNI MENI║║          ║"
            );
            Write(
                "╠══════════╣╚════════════════════════════════════════════════════════════════════════════════════════════════════════════╝║          ║"
            );
            Write(
                "║Odgovor:  ║                                                                                                              ║          ║"
            );
            Write(
                "╚══════════╩══════════════════════════════════════════════════════════════════════════════════════════════════════════════╩══════════╝"
            );

            Console.SetCursorPosition(9, 4);

            try
            {
                // Čitanje Odgovora:
                var odg = int.Parse(Console.ReadLine() ?? string.Empty);

                // Ako je odgovor:
                if (odg == 1)
                {
                    nastavitiMenuGlobal = 2;
                    return true;
                }
                else if (odg == 2)
                {
                    nastavitiMenuGlobal = 1;
                    return true;
                }
                else if (odg == 3)
                {
                    nastavitiMenuGlobal = 0;
                    return true;
                }
                else if (odg == 4)
                {
                    nastavitiProgram = "DA".ToLowerInvariant();
                }
                else if (odg > 4)
                {
                    Console.Clear();
                    Console.WindowHeight = 9;
                    Console.BufferHeight = 9;
                    Write(
                        "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                    );
                    Write(
                        "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                    );
                    Write(
                        "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite DA.!!!        ║                              ║"
                    );
                    Write(
                        "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                    );
                    Write(
                        "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                    );
                    Write(
                        "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                    );
                    Write(
                        "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                    );
                    Write(
                        "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                    );
                    Console.SetCursorPosition(83, 5);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    odgovor = Console.ReadLine();

                    if (odgovor != null && odgovor.ToLowerInvariant() == "DA".ToLowerInvariant())
                    {
                        NastavitiProgramMetoda();
                    }
                    #region TRENUTNO NEPOTREBNO
                    //else if(odgovor != null)
                    //{
                    //    NastavitiProgramMetoda();
                    //}
                    #endregion
                    else if (odgovor == String.Empty)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WindowHeight = 10;
                            Console.BufferHeight = 10;
                            Write(
                                "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                            );
                            Write(
                                "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                            );
                            Write(
                                "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                            );
                            Write(
                                "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                            );
                            Write(
                                "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                            );
                            Write(
                                "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                            );
                            Write(
                                "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                            );
                            Write(
                                "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                            );
                            Write(
                                "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                            );
                            Console.SetCursorPosition(83, 6);
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            odgovor = Console.ReadLine();
                        } while (odgovor == String.Empty);
                        NastavitiProgramMetoda();
                    }
                    else if (odgovor == "NE".ToLowerInvariant())
                    {
                        counter = 13;
                        Console.Clear();
                        Console.WindowHeight = 6;
                        Console.BufferHeight = 6;
                        Write(
                            "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                        );
                        Write(
                            "║                             ║  ╔══════════════════════════════════════════════════════════════════╗ ║                              ║"
                        );
                        Write(
                            "║                             ║  ║UPRAVO STE IZAŠLI IZ PROGRAMA.ZA POTPUNO GAŠENJE PRITISNITE ENTER.║ ║                              ║"
                        );
                        Write(
                            "║                             ║  ╚══════════════════════════════════════════════════════════════════╝ ║Ajdin Ahmagić©                ║"
                        );
                        Write(
                            "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                        );
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        //NastavitiProgramMetoda();
                    }
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WindowHeight = 9;
                Console.BufferHeight = 9;
                Write(
                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                );
                Write(
                    "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                );
                Write(
                    "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite DA.!!!        ║                              ║"
                );
                Write(
                    "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                );
                Write(
                    "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                );
                Write(
                    "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                );
                Write(
                    "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                );
                Write(
                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                );
                Console.SetCursorPosition(83, 5);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                odgovor = Console.ReadLine();

                if (odgovor != null && odgovor.ToLowerInvariant() == "DA".ToLowerInvariant())
                {
                    NastavitiProgramMetoda();
                }
                else if (odgovor == String.Empty)
                {
                    do
                    {
                        Console.Clear();
                        Console.WindowHeight = 10;
                        Console.BufferHeight = 10;
                        Write(
                            "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                        );
                        Write(
                            "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                        );
                        Write(
                            "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                        );
                        Write(
                            "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                        );
                        Write(
                            "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                        );
                        Write(
                            "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                        );
                        Write(
                            "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                        );
                        Write(
                            "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                        );
                        Write(
                            "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                        );
                        Console.SetCursorPosition(83, 6);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        odgovor = Console.ReadLine();
                    } while (odgovor == String.Empty);
                    NastavitiProgramMetoda();
                }
                else if (odgovor == "NE".ToLowerInvariant())
                {
                    counter = 13;
                    Console.Clear();
                    Console.WindowHeight = 6;
                    Console.BufferHeight = 6;
                    Write(
                        "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                    );
                    Write(
                        "║                             ║  ╔══════════════════════════════════════════════════════════════════╗ ║                              ║"
                    );
                    Write(
                        "║                             ║  ║UPRAVO STE IZAŠLI IZ PROGRAMA.ZA POTPUNO GAŠENJE PRITISNITE ENTER.║ ║                              ║"
                    );
                    Write(
                        "║                             ║  ╚══════════════════════════════════════════════════════════════════╝ ║                              ║"
                    );
                    Write(
                        "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                    );
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadKey();
                    //NastavitiProgramMetoda();
                }
                Console.ResetColor();
            }
            catch
            {
                Console.Clear();
                Console.WindowHeight = 9;
                Console.BufferHeight = 9;
                Write(
                    "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                );
                Write(
                    "║                             ║    !!!Utipkali ste pogrešan broj ili karakter, pokušajte ponovno!!!   ║                              ║"
                );
                Write(
                    "║                             ║           !!!Pokušajte Ponovno.Za ponovni odabir recite DA.!!!        ║                              ║"
                );
                Write(
                    "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                );
                Write(
                    "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                );
                Write(
                    "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                );
                Write(
                    "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                );
                Write(
                    "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                );
                Console.SetCursorPosition(83, 5);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                odgovor = Console.ReadLine();

                if (odgovor != null && odgovor.ToLowerInvariant() == "DA".ToLowerInvariant())
                {
                    NastavitiProgramMetoda();
                }
                else if (odgovor == String.Empty)
                {
                    do
                    {
                        Console.Clear();
                        Console.WindowHeight = 10;
                        Console.BufferHeight = 10;
                        Write(
                            "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                        );
                        Write(
                            "║                             ║          !!!Utipkali ste pogrešan broj ili karakter, ponovno!!!       ║                              ║"
                        );
                        Write(
                            "║                             ║  !!!MOLIM VAS ODABERITE 'DA' ILI 'NE' SVI DRUGI UNOSI SU NEVAŽEĆI!!!  ║                              ║"
                        );
                        Write(
                            "║                             ║               !!!ZA POTPINI IZLAZ IZ PROGRAMA RECITE 'NE'!!!          ║                              ║"
                        );
                        Write(
                            "║                             ╠═══════════════════════════════════════════════════════════════════════╣                              ║"
                        );
                        Write(
                            "║                             ║            ╔═══════════════════════════════════════════════╗          ║                              ║"
                        );
                        Write(
                            "║                             ║            ║        Da li želite da ponovite DA/NE:        ║          ║                              ║"
                        );
                        Write(
                            "║                             ║            ╚═══════════════════════════════════════════════╝          ║                              ║"
                        );
                        Write(
                            "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                        );
                        Console.SetCursorPosition(83, 6);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        odgovor = Console.ReadLine();
                    } while (odgovor == String.Empty);
                    NastavitiProgramMetoda();
                }
                else if (odgovor == "NE".ToLowerInvariant())
                {
                    counter = 13;
                    Console.Clear();
                    Console.WindowHeight = 6;
                    Console.BufferHeight = 6;
                    Write(
                        "╔═════════════════════════════╦═══════════════════════════════════════════════════════════════════════╦══════════════════════════════╗"
                    );
                    Write(
                        "║                             ║  ╔══════════════════════════════════════════════════════════════════╗ ║                              ║"
                    );
                    Write(
                        "║                             ║  ║UPRAVO STE IZAŠLI IZ PROGRAMA.ZA POTPUNO GAŠENJE PRITISNITE ENTER.║ ║                              ║"
                    );
                    Write(
                        "║                             ║  ╚══════════════════════════════════════════════════════════════════╝ ║                              ║"
                    );
                    Write(
                        "╚═════════════════════════════╩═══════════════════════════════════════════════════════════════════════╩══════════════════════════════╝"
                    );
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadKey();
                    //NastavitiProgramMetoda();
                }
                Console.ResetColor();
            }
            return false;
        }
        #endregion

        #region NapisiPunuCrtu Metoda

        private static void Write(string value)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(value);

            Console.ResetColor();
        }
        #endregion// NapisiPunuCrtuMetoda
    }
}
