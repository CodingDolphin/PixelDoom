using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Eventhandler
    {

        //Kampfsystem

        public void starteKampf(Spieler Spieler1, Gegenstande Inventar, HeldStatus HUD, Karte Karte)
        {
            //Kampf Initsialisieren Objekte erstellen Werte zuweisen

            Boolean istImKampf = true;
            Random randMonsterSchaden = new Random();
            Random randSchaden = new Random();
            Random randBlockchance = new Random();
            Gegner Monster = new Gegner();
            ConsoleKeyInfo taste;
            Monster.erstelleMonster(Monster,Karte.Level);

            //Kampfwerte Übergeben

            int SpielerHP = Spieler1.getSpielerLeben;
            int SpielerMaxHP = Spieler1.getSpielerMaxLeben + Spieler1.getSpielerRingHP;
            int SpielerArmor = Spieler1.getSpielerArmor;
            int SpielerAngriff = Spieler1.getSpielerAngriff + Spieler1.getSpielerWaffe;


            

            //Monster Werte

            int MonsterHP      =  Monster.getMonsterHP;
            int MonsterMaxHP   =  Monster.getMonsterMaxHP;
            int MonsterAngriff =  Monster.getMonsterAngriff;
            String MonsterTyp  =  Monster.getMonsterTyp;
            int MonsterKrit = 0;
            


            //StartText

            HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, SpielerAngriff, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterAngriff, 1);

            //Monster erstellen

            while (istImKampf == true)
            {

                //Kritschischer Treffer
                

                taste = Console.ReadKey();

                switch (taste.Key)
                {

                    //Angriff !
                        
                    case ConsoleKey.A:
                        
                        //Spielerschaden

                        int SpielerSchaden = SpielerAngriff + randSchaden.Next(1, 5);

                        MonsterHP = MonsterHP - SpielerSchaden;
                        HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, SpielerSchaden, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterAngriff, 2);

                        //Monsterschaden

                        int MonsterSchaden = MonsterAngriff + randMonsterSchaden.Next(1, 5) - SpielerArmor;

                        if (MonsterKrit == 5)
                        {
                            MonsterSchaden = 5 + Convert.ToInt32(MonsterSchaden * 1.5);
                        }

                        if (MonsterSchaden <= 0) { MonsterSchaden = 0; }
                        SpielerHP = SpielerHP - MonsterSchaden;

                        //HUD Aktualisieren

                        HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, SpielerSchaden, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterSchaden, 3);


                        break;

                        //Verteidigen

                    
                    case ConsoleKey.D:
                   
                        int Block = randBlockchance.Next(1, 5);
                        int SpielerSchadenBlock = SpielerAngriff + randSchaden.Next(1, 3);
                        int MonsterSchadenBlock = MonsterAngriff + randMonsterSchaden.Next(1, 5) - SpielerArmor;

                        switch (Block)
                        {

                         //Fall nicht geblockt !

                            case 1:
                                   
                                    MonsterSchadenBlock = MonsterAngriff + randMonsterSchaden.Next(1, 5) - SpielerArmor;

                                    //Bei Krit Schaden erhöhen

                                    if (MonsterKrit == 5)
                                    {
                                        MonsterSchadenBlock = MonsterSchadenBlock * 2;
                                    }

                                    if (MonsterSchadenBlock <= 0) { MonsterSchadenBlock = 0; }


                                    SpielerHP = SpielerHP - MonsterSchadenBlock;

                        //HUD Aktualisieren

                        HUD.erstelleKampftext(SpielerHP, SpielerMaxHP,SpielerSchadenBlock, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterSchadenBlock, 6);break;

                        //Fall geblockt !

                            default:

                                MonsterSchadenBlock = randBlockchance.Next(1, 5);
                                MonsterHP = MonsterHP - MonsterSchadenBlock;
                                HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, SpielerSchadenBlock, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterSchadenBlock, 5);
                                HUD.erstelleKampftext(SpielerHP, SpielerMaxHP,SpielerSchadenBlock, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterSchadenBlock, 1);break;

                        }
                        break;

                }

                HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, SpielerAngriff, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterAngriff, 1);

                //Gewonnen oder verloren

                if (SpielerHP <= 0)
                {
                    Console.Clear();
                    HighScore Spiel = new HighScore();
                    Spiel.dateiErstellen(Spieler1, Spieler1.getPunktZahl);
                    Spiel.dateiLesen(Spieler1);
                    System.Environment.Exit(0);

                }

                if (MonsterHP <= 0) 
                {
                    //Game Over
                    
                    if (SpielerHP <= 0)
                    {
                        Console.Clear();
                        HighScore Spiel = new HighScore();
                        Spiel.dateiErstellen(Spieler1, Spieler1.getPunktZahl);
                        Spiel.dateiLesen(Spieler1);
                        System.Environment.Exit(0);

                    }
                    Spieler1.setSpielerLeben = SpielerHP;
                    HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, SpielerAngriff, MonsterHP, MonsterMaxHP, MonsterTyp, MonsterAngriff, 4);

                    int Erfahrung = Convert.ToInt32(Karte.Level);

                    Spieler1.setSpielerErfahrung = Spieler1.getSpielerErfahrung + Erfahrung;
                    Spieler1.setPunktzahl = Spieler1.getPunktZahl + 5 + Erfahrung;
                    Spieler1.levelUP(Spieler1);
                    HUD.zeichneHud(Spieler1, Inventar);
                    break;

                }

                //Crit oder kein Crit

                MonsterKrit = randMonsterSchaden.Next(1, 7);

                if (MonsterKrit == 5)
                {
                    HUD.erstelleKampftext(SpielerHP, SpielerMaxHP, 0, MonsterHP, MonsterMaxHP, MonsterTyp, 0, 7);
                }

                }

                //Game Over

                if (SpielerHP <= 0)
                {
                    Console.Clear();
                    HighScore Spiel = new HighScore();
                    Spiel.dateiErstellen(Spieler1, Spieler1.getPunktZahl);
                    Spiel.dateiLesen(Spieler1);
                    System.Environment.Exit(0);
                }   
           

                }
            }
        }
    


           