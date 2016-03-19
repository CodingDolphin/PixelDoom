using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Menu
    {
        //Variablen

        Boolean istImStartMenu;

        //Konstruktor

        public Menu()
        {
            Console.SetWindowSize(80, 40);         
            istImStartMenu = true;
            Console.CursorVisible = false;
        }

        //Grundlegendes Menü aufbauen

        public void initStartMenu(Menu Startmenu)
        {
            while (istImStartMenu == true)
        {
            Console.Clear();
            Console.SetCursorPosition(26, 4);
            Console.WriteLine("Willkommen beim Pixel Doom");
            Console.SetCursorPosition(28, 14);
            Console.WriteLine("[ 1 ]-Neues Spiel");
            Console.SetCursorPosition(28, 15);
            Console.WriteLine("[ 2 ]-Highscore");
            Console.SetCursorPosition(28, 16);
            Console.WriteLine("[ 3 ]-Exit");
            Console.SetCursorPosition(46, 35);
            Console.WriteLine("Produziert von Michael Börner");
            Console.SetCursorPosition(5, 35);
            Console.WriteLine("Alle Rechte Vorbehalten");
            
          //Switch Auswahl 

            string menuAuswahl;
            Console.SetCursorPosition(26, 23);
            Console.Write("Bitte Auswahl eingeben: ");
            menuAuswahl = Console.ReadLine();

                switch(menuAuswahl)
                {
                    case "1":

                        //ALLE OBJEKTE ERSTELLEN FÜR DEN START

                        Karte Karte = new Karte(20, 40 , 20 , 20); //Kartenhöhe Kartenbreite und Cursor X Y
                        HeldStatus HUD = new HeldStatus(20 , 40);
                        Eventhandler Events = new Eventhandler(); 
                        Hauptschleife Spielschleife = new Hauptschleife();  
                        Spieler Spieler1 = new Spieler();
                        Gegenstande Inventar = new Gegenstande();
                        HighScore Punkte = new HighScore();
                        Shop Kaufen = new Shop();


                        Karte.initKarte(Events,HUD);
                        Karte.zeichneKarte();
                        HUD.zeichneHud(Spieler1, Inventar);
                        Spielschleife.spielSchleife(Karte, HUD, Events,Spieler1,Startmenu,Inventar,Kaufen);
                        break; 

                        //Highscore

                    case "2":

                             Console.Clear();
                             Spieler Spieler2 = new Spieler();
                             HighScore punkteAbfragen = new HighScore();
                             punkteAbfragen.dateiLesen(Spieler2);
                             Console.ReadKey();
                             
                        break; 

                    case "3":

                        System.Environment.Exit(0);
                   
                    break;

                    default: break;              
                }



         
                
        }

        }


        }

    }

