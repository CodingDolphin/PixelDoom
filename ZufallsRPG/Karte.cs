using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Karte
    {
        //Koordinaten Feldstatus und Maximale Spielfeldgröße

        int yCursorKoordinate;
        int xCursorKoordinate;
        int kartenHöhe;
        int kartenBreite;
        public double Level;
        public static int feldMenge;
        public int[,] feldStatus;

        //Konstruktor

        public Karte(int initKartenHöhe, int initKartenBreite, int yCursor,int xCursor)
        {
            Console.Clear();
            yCursorKoordinate = initKartenHöhe / 2;
            xCursorKoordinate = initKartenBreite / 5;
            kartenHöhe = initKartenHöhe;
            kartenBreite = initKartenBreite;
            feldMenge = 0;
            Level = 0.8;
            //Console.WriteLine("Konstruktor");            
        }

        //Karte Initsialisieren und Felder belegen

        public void initKarte(Eventhandler Events,HeldStatus HUD)
    {
        feldStatus = new int[kartenHöhe, kartenBreite];
        Random ZufallsGenerator = new Random();

        //Feld Daten füllen

        for (int y = 0 ; y < kartenHöhe; y++) //Y Achse
        {
            
           
            for (int x = 0; x < kartenBreite; x++) //X Achse
            {
                Console.SetCursorPosition(x + 0, y + 0);

                if (y == 0 | x == 0 | y == kartenHöhe -1 | x == kartenBreite -1)
                {
                    feldStatus[y, x] = 1;
                }
                else
                {
                    feldStatus[y, x] = 0;

                    //Zufalls Generator 1-100 entweder 2: Geld, 3: Item, 4: Gegner
                    
                    int feldZufall = ZufallsGenerator.Next(1,100);

                    switch (feldZufall)
                    {
                        case 2: feldStatus[y, x] = 2; feldMenge++; break;
                        case 3: feldStatus[y, x] = 3; feldMenge++; break;
                        case 4: feldStatus[y, x] = 4; feldMenge++; break;
                        
                    }

           
                    //Felder zuweisen Ende
                }
            }
        }

        Level = Level + 0.2;
    }

        //Zeichne Karte

        public void zeichneKarte()
        {

            for (int y = 0; y < kartenHöhe; y++) //Y Achse
            {


                for (int x = 0; x < kartenBreite; x++) //X Achse
                {
                    Console.SetCursorPosition(x + 0, y + 0);

                    if (y == 0 | x == 0 | y == kartenHöhe - 1 | x == kartenBreite - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.WriteLine(" "); Console.ResetColor();
                    }
                    else
                    {
                        //Switch je nach Feldwert Zeichnung verändern

                        switch (feldStatus[y,x])
                        {
                            case 2: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("$"); Console.ResetColor();break;
                            case 3: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("+"); Console.ResetColor();break;
                            case 4: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("x"); Console.ResetColor(); break;
                            default: Console.BackgroundColor = ConsoleColor.Black; Console.WriteLine(" "); Console.ResetColor();break;

                        }

                        //Felder zeichnen

                   }
                }
            }

        }

            
    }
}
