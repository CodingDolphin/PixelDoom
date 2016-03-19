using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Hauptschleife
    {
        Boolean istSpielAktiv;

        public Hauptschleife()
        {
            istSpielAktiv = true;
        }

        public void spielSchleife(Karte Karte, HeldStatus HUD, Eventhandler Events, Spieler Spieler1, Menu Startmenu, Gegenstande Inventar,Shop Kaufen)
        {

            //Spieler1 Start Werte

            Console.SetCursorPosition(1, 1);
            Spieler1.setXSpielerPos = 1;
            Spieler1.setYSpielerPos = 1;
            Console.Write("@");

            while (istSpielAktiv == true)
            {

                //Tasten Abfragen
                Console.SetCursorPosition(1, 22);
                ConsoleKeyInfo taste;
                taste = Console.ReadKey();
                HUD.zeichneHud(Spieler1, Inventar);


                switch (taste.Key)
                {
                    //Pfeil Rauf

                    case ConsoleKey.UpArrow:

                        switch (Karte.feldStatus[Spieler1.getySpielerPos - 1, Spieler1.getxSpielerPos])
                        {
                            case 0: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 0); Spieler1.spielerGehtHoch(Spieler1, Karte); break;

                            case 1: break;

                            case 2: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 2); Spieler1.spielerGehtHoch(Spieler1, Karte); break;

                            case 3: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 3); Spieler1.spielerGehtHoch(Spieler1, Karte); break;

                            case 4: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 4); Spieler1.spielerGehtHoch(Spieler1, Karte); break;
                        }
                        break;
                      

                    //Pfeil Runter

                    case ConsoleKey.DownArrow:

                        switch (Karte.feldStatus[Spieler1.getySpielerPos + 1, Spieler1.getxSpielerPos])
                        {
                            case 0: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 0); Spieler1.spielerGehtRunter(Spieler1, Karte); break;

                            case 1: break;

                            case 2: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 2); Spieler1.spielerGehtRunter(Spieler1, Karte); break;

                            case 3: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 3); Spieler1.spielerGehtRunter(Spieler1, Karte); break;

                            case 4: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 4); Spieler1.spielerGehtRunter(Spieler1, Karte); break;
                        }
                        break;


                    //Pfeil Links

                    case ConsoleKey.LeftArrow:

                        switch (Karte.feldStatus[Spieler1.getySpielerPos, Spieler1.getxSpielerPos - 1])
                        {
                            case 0: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 0); Spieler1.spielerGehtLinks(Spieler1, Karte); break;

                            case 1: break;

                            case 2: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 2); Spieler1.spielerGehtLinks(Spieler1, Karte); break;

                            case 3: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 3); Spieler1.spielerGehtLinks(Spieler1, Karte); break;

                            case 4: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 4); Spieler1.spielerGehtLinks(Spieler1, Karte); break;

                        }
                        break;

                    //Pfeil Rechts

                    case ConsoleKey.RightArrow:

                        switch (Karte.feldStatus[Spieler1.getySpielerPos, Spieler1.getxSpielerPos + 1])
                        {
                            case 0: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 0); Spieler1.spielerGehtRechts(Spieler1, Karte); break;

                            case 1: break;

                            case 2: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 2); Spieler1.spielerGehtRechts(Spieler1, Karte); break;

                            case 3: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 3); Spieler1.spielerGehtRechts(Spieler1, Karte); break;

                            case 4: feldPrüfen(Spieler1, Karte, HUD, Inventar, Events, 4); Spieler1.spielerGehtRechts(Spieler1, Karte); break;
                        }
                        break;

                    //Austrüstungs Auswahl

                    case ConsoleKey.W: Inventar.selectWeapon(HUD, Spieler1); HUD.zeichneHud(Spieler1, Inventar); Karte.zeichneKarte();zeichneSpielerPos(Spieler1) ; break;
                    case ConsoleKey.A: Inventar.selectArmor(HUD, Spieler1); HUD.zeichneHud(Spieler1, Inventar); Karte.zeichneKarte(); zeichneSpielerPos(Spieler1); break;
                    case ConsoleKey.R: Inventar.selectRing(HUD, Spieler1); HUD.zeichneHud(Spieler1, Inventar); Karte.zeichneKarte(); zeichneSpielerPos(Spieler1); break;
                    case ConsoleKey.E: Kaufen.verkaufeItem(Spieler1, Inventar); HUD.zeichneHud(Spieler1, Inventar); Karte.zeichneKarte(); zeichneSpielerPos(Spieler1);
                         Inventar.selectArmor(HUD, Spieler1); 
                         Inventar.selectWeapon(HUD, Spieler1);
                         Inventar.selectRing(HUD, Spieler1);break;
                }
            }
        }

        //Spieler neu Zeichnen

        public void zeichneSpielerPos(Spieler Spieler1)
        {
            int y = Spieler1.getySpielerPos;
            int x = Spieler1.getxSpielerPos;
            Console.SetCursorPosition(x, y);
            Console.Write("@");
        }

        public void feldPrüfen(Spieler Spieler1, Karte Karte, HeldStatus HUD,Gegenstande Inventar,Eventhandler Events, int feldnummer)
        {

         switch (feldnummer)

                        {
                            case 0: break;

                            case 1: break;

                            case 2: Spieler1.sammelMunze(HUD, Spieler1, Inventar); Karte.feldMenge--; break;

                            case 3: Spieler1.sammelHP(HUD, Spieler1, Inventar); Karte.feldMenge--; break;

                            case 4: Events.starteKampf(Spieler1, Inventar, HUD, Karte); Karte.zeichneKarte(); zeichneSpielerPos(Spieler1); Karte.feldMenge--; break;       
                                   
                        }

        

         if (Karte.feldMenge <= 0)
         {
             Karte.initKarte(Events, HUD);
             Karte.zeichneKarte();
             zeichneSpielerPos(Spieler1);
         }
             
         }
       }
    }



