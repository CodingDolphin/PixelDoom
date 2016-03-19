using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class HeldStatus
    {
        //Karteneigenschaften zur Anpassung
        int Kartenhöhe;
        int Kartenbreite;

        public HeldStatus(int Höhe, int Breite)
        {
            Kartenhöhe = Höhe;
            Kartenbreite = Breite;
            aktualisiereArmor("Leer");
            aktualisiereWaffen("Leer");
            aktualisiereRing("Leer");
        }

        //Hud Zeichnen

        public void zeichneHud(Spieler Spieler1,Gegenstande Inventar)
        {
            int ringHP = Spieler1.getSpielerRingHP + Spieler1.getSpielerMaxLeben;
            Console.SetCursorPosition(Kartenbreite + 14, 1);
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Spieler Status"); Console.ResetColor();
            Console.SetCursorPosition(Kartenbreite + 11, 5);
            Console.WriteLine("Aktuelles Level:  " + Spieler1.getSpielerLevel);
            Console.SetCursorPosition(Kartenbreite + 11, 8);
            Console.WriteLine("Erfahrung:        " + Spieler1.getSpielerErfahrung + "/" + Spieler1.getSpielerNextLevel);
            Console.SetCursorPosition(Kartenbreite + 11, 10);
            Console.WriteLine("Spieler Leben:    " + Spieler1.getSpielerLeben + "/" + ringHP + ("  "));
            Console.SetCursorPosition(Kartenbreite + 11, 12);
            Console.Write("Spieler Angriff:  " + Spieler1.getSpielerAngriff + " + " + Spieler1.getSpielerWaffe);
            Console.SetCursorPosition(Kartenbreite + 11, 14);
            Console.WriteLine("Spieler Rüstung:  " + Spieler1.getSpielerArmor);
            Console.SetCursorPosition(Kartenbreite + 11, 16);
            Console.WriteLine("Spieler Münzen:   " + Spieler1.getSpielerMunzen + " $");


            //Inventar

            Console.SetCursorPosition(Kartenbreite + 14, 22);
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("Inventar: "); Console.ResetColor();
            Console.SetCursorPosition(Kartenbreite + 8, 25);
            Console.Write("(E)inkaufen");
            Console.SetCursorPosition(Kartenbreite + 8, 27);
            Console.Write("(W)affe : ");
            Console.SetCursorPosition(Kartenbreite + 8, 29);
            Console.Write("(A)rmor : ");
            Console.SetCursorPosition(Kartenbreite + 8, 31);
            Console.Write("(R)ing  : ");


            //Anleitung

            Console.SetCursorPosition(1, 22);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ereigniss Text:");
            Console.SetCursorPosition(1, 22);
            Console.ResetColor();


            //Kampftext
        }

        public void erstelleKampftext(int SpielerHP,int SpielerMaxHP,int Spielerschaden, int MonsterHP,int MonsterMaxHP, string MonsterName,int MonsterSchaden, int kampfIndex)
        {
            //Switch Anweisung für Kampf Status

            switch(kampfIndex)
            {
                    //Kampfbeginn

            case 1:

            Console.SetCursorPosition(1, 25);
            Console.WriteLine("Kampf Beginnt!                                 ");
            Console.SetCursorPosition(1, 27);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(MonsterName);Console.ResetColor();
            Console.WriteLine(" HP " + MonsterHP + "/" + MonsterMaxHP + " - " + "Spieler HP " + SpielerHP + " / " + SpielerMaxHP + "   ");
            Console.SetCursorPosition(1, 35);
            Console.Write("(A)Angreifen - (D)efend - Eingabe: ");
            break;

                    //Angriff

            case 2:
                   Console.SetCursorPosition(1, 37); Console.Write(MonsterName + "                                                    ");
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.SetCursorPosition(1, 30); Console.WriteLine("Du triffst " + MonsterName + " mit " + Spielerschaden + " Schaden!                 ");
                   Console.ResetColor();
                   break;

                    //MonsterAngriff

            case 3:
                   Console.SetCursorPosition(1, 37); Console.Write("                                                    ");
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.SetCursorPosition(1, 32); Console.WriteLine(MonsterName + " trifft dich mit " + MonsterSchaden + " Schaden!                     "); 
                   Console.ResetColor();break;

                    //Sieg !

            case 4:
                    Console.SetCursorPosition(1, 37); Console.Write("                                                    ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(1, 25);Console.WriteLine("Gloreicher Sieg !!!                        ");
                    Console.ResetColor();
                    Console.SetCursorPosition(1, 27);Console.WriteLine("                                           "); 
                    Console.SetCursorPosition(1, 35);Console.WriteLine("                                           "); 
                    Console.SetCursorPosition(1, 32);Console.WriteLine("                                           "); 
                    Console.SetCursorPosition(1, 30);Console.WriteLine("                                                 "); 
                    break;
                    
                    //Erfolgreich geblockt

            case 5:
                    
                   Console.SetCursorPosition(1, 37); Console.Write("                                                    ");
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.SetCursorPosition(1, 30); Console.WriteLine("Du Blockst erfolgreich " + MonsterName + " bekommt " + MonsterSchaden + " Schaden        ");
                   Console.SetCursorPosition(1, 32); Console.WriteLine("                                                                   "); 
                   Console.ResetColor();break;

                    //Block nicht Erfolgreich

            case 6: 
                   Console.SetCursorPosition(1, 37); Console.Write("                                                    ");
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.SetCursorPosition(1, 32); Console.WriteLine(MonsterName + " trifft dich mit " + MonsterSchaden + " Schaden!       ");
                   Console.SetCursorPosition(1, 30); Console.WriteLine("                                                                     ");
                   Console.ResetColor(); break;

            case 7: Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(1, 37); Console.Write(MonsterName + " scheint Wütend zu sein !");
                    Console.SetCursorPosition(1, 35);Console.ResetColor();
                    break;
                


        }
        }

        //Hud aktualiesieren

        public void aktualisiereWaffen(String Waffe)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(Kartenbreite + 18, 27);
            Console.WriteLine(Waffe + "                 ");
            Console.ResetColor();
        } 
        public void aktualisiereArmor(String Armor)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Kartenbreite + 18, 29);
            Console.WriteLine(Armor + "                 ");
            Console.ResetColor();
        }
        public void aktualisiereRing(String Ring)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan; ;
            Console.SetCursorPosition(Kartenbreite + 18, 31);
            Console.WriteLine(Ring + "                 ");
            Console.ResetColor();
        }
    }
}
