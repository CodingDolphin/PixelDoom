using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Shop
    {
       
        int Auswahl = 1;
        int preis;
        public Boolean istImShop;

        public void verkaufeItem(Spieler Spieler1,Gegenstande Inventar)
        {
             istImShop = true;

            while (istImShop == true)
            {
                Console.Clear();
                Console.SetCursorPosition(24, 4); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Willkommen beim Pixel Doom Shop !"); Console.ResetColor();
                Console.SetCursorPosition(4, 10); Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Höllenstimmung hier aber wenigstens keine Höllen Preise vieleicht :-) !"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(4, 32); Console.WriteLine("Was möchten Sie kaufen:"); Console.ResetColor();

                //Waffen
               
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(7, 15); Console.WriteLine("Waffen:"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(4, 20); Console.Write("1: Dolch"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 20$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(4, 22); Console.Write("2: Schwert"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 40$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(4, 24); Console.Write("3: Säbel"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 60$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(4, 26); Console.Write("4: Feuriges Schwert"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 75$"); Console.ResetColor();



                //Rüstung

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(35, 15); Console.WriteLine("Rüstung:"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(32, 20); Console.Write("5: Leder"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 20$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(32, 22); Console.Write("6: Ketten"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 40$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(32, 24); Console.Write("7: Schuppen"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 70$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(32, 26); Console.Write("8: Drachenpanze"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 120$"); Console.ResetColor();

                //Ringe

                Console.ForegroundColor = ConsoleColor.Cyan; Console.SetCursorPosition(65, 15); Console.WriteLine("Ringe:"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(58, 20); Console.Write("9: Silber Ring"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 10$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(58, 22); Console.Write("10: Rubin Ring"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 20$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(58, 24); Console.Write("11: Diamant Ring"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 30$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(58, 26); Console.Write("12: Zauber Ring"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" 50$"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(58, 32); Console.WriteLine("(E):Exit"); Console.ResetColor();

                
                Console.SetCursorPosition(28, 15);
                try
                {
                    Console.SetCursorPosition(28, 32);
                    Auswahl = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    istImShop = false;
                    break;
                }

                

                switch(Auswahl)
                {
                    case 1: if 

                        (Inventar.istImBesitzDolch == false)
                        {
                            preis = 20; Inventar.istImBesitzDolch = preisCheck(Spieler1, preis); 
                        }   break;


                    case 2: if

                        (Inventar.istImBesitzSchwert == false)
                        {
                            preis = 40; Inventar.istImBesitzSchwert = preisCheck(Spieler1, preis);
                        } break;




                    case 3: if

                        (Inventar.istImBesitzSabel == false)
                        {
                            preis = 60; Inventar.istImBesitzSabel = preisCheck(Spieler1, preis);
                        } break;


                    case 4: if

                        (Inventar.istImBesitzFeurigesSchwert == false)
                        {
                            preis = 75; Inventar.istImBesitzFeurigesSchwert = preisCheck(Spieler1, preis);
                        } break;


                    case 5: if

                        (Inventar.hatLeder == false)
                        {
                            preis = 20; Inventar.hatLeder = preisCheck(Spieler1, preis);
                        } break;


                    case 6: if

                        (Inventar.hatKetten == false)
                        {
                            preis = 40; Inventar.hatKetten = preisCheck(Spieler1, preis);
                        } break;

                    case 7: if

                        (Inventar.hatSchuppen == false)
                        {
                            preis = 70; Inventar.hatSchuppen = preisCheck(Spieler1, preis);
                        } break;


                    case 8: if

                        (Inventar.hatDrachenschuppen == false)
                        {
                            preis = 120; Inventar.hatDrachenschuppen = preisCheck(Spieler1, preis);
                        } break;


                    case 9: if

                        (Inventar.hatSilberRing == false)
                        {
                            preis = 10; Inventar.hatSilberRing = preisCheck(Spieler1, preis);
                        } break;


                    case 10: if

                        (Inventar.hatRubinRing == false)
                        {
                            preis = 20; Inventar.hatRubinRing = preisCheck(Spieler1, preis);
                        } break;


                    case 11: if

                        (Inventar.hatDiamantRing == false)
                        {
                            preis = 30; Inventar.hatDiamantRing = preisCheck(Spieler1, preis);
                        } break;


                    case 12: if

                        (Inventar.hatZauberRing == false)
                        {
                            preis = 50; Inventar.hatZauberRing = preisCheck(Spieler1, preis);
                        } break;
   

                }

            }
        }

                     public Boolean preisCheck(Spieler Spieler1,int Kosten)
                     {

                         if (Spieler1.getSpielerMunzen >= Kosten)
                         {
                             Boolean istOkay = true;
                             Spieler1.setSpielerMunzen = Spieler1.getSpielerMunzen - preis;
                             Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(32, 32); Console.WriteLine("Danke für Ihren Einkauf !          "); Console.ResetColor();
                             Console.ReadKey();
                             Console.Clear();
                             istImShop = false;
                             return istOkay;
                         }
                         else 
                         {
                         Boolean istNichtOkay = false;
                         Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(32, 32); Console.WriteLine("Nicht genug Münzen !                 "); Console.ResetColor();
                         istImShop = false;
                         Console.ReadKey();
                         Console.Clear();
                         return istNichtOkay;
                         }
                         

                        
                     }

    }
    }

