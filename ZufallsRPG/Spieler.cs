using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Spieler
    {
        //Spieler Attribute
        int SpielerLeben;
        int SpielerMaxLeben;
        int SpielerAngriff;
        int SpielerRüstung;
        int SpielerErfahrung;
        int SpielerLevel;
        int SpielerNextLevel;
        int ySpielerPos;
        int xSpielerPos;
        int SpielerWaffe;
        int SpielerArmor;
        int SpielerRingHP;
        int SpielerMunzen;
        int PunktZahl;

        //Konstruktor
        public Spieler()
        {
            SpielerLevel = 1;
            SpielerNextLevel = 5;
            SpielerLeben = 75;
            SpielerMaxLeben = 75;
            SpielerAngriff = 3;
            SpielerRüstung = 0;
            ySpielerPos = 1;
            SpielerErfahrung = 0;
            xSpielerPos = 1;
            SpielerWaffe = 0;
            SpielerArmor = 0;
            SpielerRingHP = 0;
            SpielerMunzen = 0;
        }

        //Get Set 

        public int getPunktZahl
        {
            get { return PunktZahl; }
        }

        public int getSpielerWaffe
        {
            get { return SpielerWaffe; }
        }

        public int getSpielerArmor
        {
            get { return SpielerArmor; }
        }

        public int getSpielerRingHP
        {
            get { return SpielerRingHP; }
        }

        public int getSpielerLeben
        {
            get { return SpielerLeben; }
        }

        public int getSpielerMaxLeben
        {
            get { return SpielerMaxLeben; }
        }

        public int getSpielerAngriff
        {
            get { return SpielerAngriff; }
        }

        public int getSpielerRüstung
        {
            get { return SpielerRüstung; }
        }

        public int getSpielerErfahrung
        {
            get { return SpielerErfahrung; }
        }

        public int getSpielerLevel
        {
            get { return SpielerLevel; }
        }

        public int getSpielerNextLevel
        {
            get { return SpielerNextLevel; }
        }

        public int getySpielerPos
        {
            get { return ySpielerPos; }
        }

        public int getxSpielerPos
        {
            get { return xSpielerPos; }
        }

        public int getSpielerMunzen
        {
            get { return SpielerMunzen; }
        }


        //Set Y Position

        public int setYSpielerPos
        {
            set { ySpielerPos = value; }
        }

        //Set x Position

        public int setXSpielerPos
        {
            set { xSpielerPos = value; }
        }

        public int setSpielerLeben
        {
            set { SpielerLeben = value; }
        }

        public int setSpielerMaxLeben
        {
            set { SpielerMaxLeben = value; }
        }

        public int setSpielerAngriff
        {
            set { SpielerAngriff = value; }
        }

        public int setSpielerRüstung
        {
            set { SpielerRüstung = value; }
        }

        public int setSpielerLevel
        {
            set { SpielerLevel = value; }
        }

        public int setSpielerNextLevel
        {
            set { SpielerNextLevel = value; }
        }

        public int setSpielerErfahrung
        {
            set { SpielerErfahrung = value; }
        }

        public int setSpielerWaffe
        {
            set { SpielerWaffe = value; }
        }

        public int setSpielerArmor
        {
            set { SpielerArmor = value; }
        }

        public int setSpielerRingHP
        {
            set { SpielerRingHP = value; }
        }

        public int setSpielerMunzen
        {
            set { SpielerMunzen = value; }
        }

        public int setPunktzahl
        {
            set { PunktZahl = value; }
        }

        //MünzCount

        public void sammelMunze(HeldStatus HUD,Spieler Spieler1,Gegenstande Inventar)
    {
        Random randMünze = new Random();
        int Munze = randMünze.Next(1, 10);
        Console.SetCursorPosition(1, 25); Console.WriteLine("Super "+ Munze + " Münzen gefunden !    ");
        setSpielerMunzen = getSpielerMunzen + Munze;
        HUD.zeichneHud(Spieler1, Inventar);
        setPunktzahl = getPunktZahl + Munze;
    }

        //SammelHP

        public void sammelHP(HeldStatus HUD, Spieler Spieler1, Gegenstande Inventar)
        {
            Random randHP = new Random();
            int HP = randHP.Next(2, 7);
            setSpielerLeben = getSpielerLeben + HP;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1, 25); Console.WriteLine("Heiltrank gefunden HP + " + HP + " !     ");
            setPunktzahl = getPunktZahl + HP;
            Console.ResetColor();

            
            if (Spieler1.getSpielerMaxLeben + Spieler1.getSpielerRingHP < Spieler1.getSpielerLeben)
            {
                setSpielerLeben = Spieler1.getSpielerMaxLeben + Spieler1.getSpielerRingHP;
            }
            HUD.zeichneHud(Spieler1, Inventar);

        }

        //Level UP

        public void levelUP(Spieler Spieler1)
        {
            if (getSpielerErfahrung >= getSpielerNextLevel)
            {
                double Spielerprozent = 1.2;
                setSpielerLevel = getSpielerLevel + 1;
                setSpielerNextLevel = Convert.ToInt32(getSpielerNextLevel * Spielerprozent);
                setSpielerErfahrung = 0;
                setPunktzahl = getPunktZahl + 5;
                setSpielerMaxLeben = getSpielerMaxLeben + 5;
                setSpielerLeben = getSpielerMaxLeben + 5;
                setSpielerAngriff = getSpielerAngriff + 1;

                if (Spieler1.getSpielerMaxLeben + Spieler1.getSpielerRingHP < Spieler1.getSpielerLeben)
                {
                    setSpielerLeben = Spieler1.getSpielerMaxLeben + Spieler1.getSpielerRingHP;
                }

            }  
        }

        //Spieler bewegung

        public void spielerGehtHoch(Spieler Spieler1,Karte Karte)
        {
            Console.MoveBufferArea(Spieler1.getxSpielerPos, Spieler1.getySpielerPos, 1, 1, Spieler1.getxSpielerPos, Spieler1.getySpielerPos - 1);
            Console.SetCursorPosition(Spieler1.getxSpielerPos, Spieler1.getySpielerPos);
            Karte.feldStatus[Spieler1.getySpielerPos - 1, Spieler1.getxSpielerPos] = 0;
            Spieler1.setYSpielerPos = Spieler1.getySpielerPos - 1;
        }

        public void spielerGehtRunter(Spieler Spieler1,Karte Karte)
        {
            Console.MoveBufferArea(Spieler1.getxSpielerPos, Spieler1.getySpielerPos, 1, 1, Spieler1.getxSpielerPos, Spieler1.getySpielerPos + 1);
            Console.SetCursorPosition(Spieler1.getxSpielerPos, Spieler1.getySpielerPos);
            Karte.feldStatus[Spieler1.getySpielerPos + 1, Spieler1.getxSpielerPos] = 0;
            Spieler1.setYSpielerPos = Spieler1.getySpielerPos + 1;
        }

        public void spielerGehtLinks(Spieler Spieler1,Karte Karte)
        {
            Console.MoveBufferArea(Spieler1.getxSpielerPos, Spieler1.getySpielerPos, 1, 1, Spieler1.getxSpielerPos - 1, Spieler1.getySpielerPos);
            Console.SetCursorPosition(Spieler1.getxSpielerPos, Spieler1.getySpielerPos);
            Karte.feldStatus[Spieler1.getySpielerPos, Spieler1.getxSpielerPos - 1] = 0;
            Spieler1.setXSpielerPos = Spieler1.getxSpielerPos - 1;
            
        }
        public void spielerGehtRechts(Spieler Spieler1,Karte Karte)
        {
            Console.MoveBufferArea(Spieler1.getxSpielerPos, Spieler1.getySpielerPos, 1, 1, Spieler1.getxSpielerPos + 1, Spieler1.getySpielerPos);
            Console.SetCursorPosition(Spieler1.getxSpielerPos, Spieler1.getySpielerPos);
            Karte.feldStatus[Spieler1.getySpielerPos, Spieler1.getxSpielerPos + 1] = 0;
            Spieler1.setXSpielerPos = Spieler1.getxSpielerPos + 1;
        }
    }
}
